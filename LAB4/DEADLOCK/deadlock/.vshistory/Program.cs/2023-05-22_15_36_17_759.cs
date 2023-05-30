﻿using System.Data.SqlClient;



namespace deadlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string connectionString = @"Server=LAPTOP-1COTFGBR\SQLEXPRESS; Database=MagazinAlimentar; Integrated Security=true; TrustServerCertificate=true;";
            int retryCount = 0;
            bool success = false;

            while (!success && retryCount < 3)
            {
                Console.WriteLine("Retry count: " + retryCount);

                Thread thread1 = new Thread(() =>
                {
                    Console.WriteLine("Thread1 is running!");

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Set the deadlock priority to HIGH
                        using (SqlCommand setDeadlockPriorityCommand = connection.CreateCommand())
                        {
                            setDeadlockPriorityCommand.CommandText = "SET DEADLOCK_PRIORITY LOW";
                            setDeadlockPriorityCommand.ExecuteNonQuery();
                        }

                        // Create a new transaction
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                using (SqlCommand command = connection.CreateCommand())
                                {
                                    command.Transaction = transaction;

                                    // Update statement 1
                                    command.CommandText = "UPDATE Produs SET denumire = 'Transaction 2' WHERE id_produs = 72";
                                    command.ExecuteNonQuery();

                                    // Delay for 7 seconds
                                    Thread.Sleep(7000);

                                    // Update statement 2
                                    command.CommandText = "UPDATE Producator SET nume = 'Transaction 2' WHERE id_producator = 3";
                                    command.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();
                                Console.WriteLine("Transaction committed successfully.");
                                success = true;
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 1205) // Deadlock error number
                                {
                                    // Handle deadlock, rollback the transaction, and retry
                                    Console.WriteLine("Deadlock occurred. Retrying...");

                                    transaction.Rollback();
                                    Console.WriteLine("Transaction rolled back.");
                                    retryCount++;
                                }
                                else
                                {
                                    // Handle other exceptions
                                    Console.WriteLine("Error occurred: " + ex.Message);
                                    transaction.Rollback();
                                    Console.WriteLine("Transaction rolled back.");
                                }
                            }
                        }
                    }
                });

                Thread thread2 = new Thread(() =>
                {
                    Console.WriteLine("Thread2 is running!");
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Create a new transaction
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                using (SqlCommand command = connection.CreateCommand())
                                {
                                    command.Transaction = transaction;

                                    // Update statement 1
                                    command.CommandText = "UPDATE Producator SET nume = 'Transaction 1' WHERE id_producator = 3";
                                    command.ExecuteNonQuery();

                                    // Delay for 7 seconds
                                    Thread.Sleep(7000);

                                    // Update statement 2
                                    command.CommandText = "UPDATE Produs SET denumire = 'Transaction 1' WHERE id_produs = 72";
                                    command.ExecuteNonQuery();
                                }

                                // Commit the transaction
                                transaction.Commit();
                                Console.WriteLine("Transaction committed successfully.");
                                success = true;
                            }
                            catch (SqlException ex)
                            {
                                if (ex.Number == 1205) // Deadlock error number
                                {
                                    // Handle deadlock, rollback the transaction, and retry
                                    Console.WriteLine("Deadlock occurred. Retrying...");

                                    transaction.Rollback();
                                    Console.WriteLine("Transaction rolled back.");
                                    retryCount++;
                                }
                                else
                                {
                                    // Handle other exceptions
                                    Console.WriteLine("Error occurred: " + ex.Message);
                                    transaction.Rollback();
                                    Console.WriteLine("Transaction rolled back.");
                                }
                            }
                        }
                    }
                });

                thread1.Start();
                thread2.Start();
                thread1.Join();
                thread2.Join();
            }

            if (retryCount >= 3)
            {
                Console.WriteLine("Exceeded maximum retry attempts. Aborting.");
            }
            else
            {
                Console.WriteLine("All transactions completed.");
            }
        }
    }
}