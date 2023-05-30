using System.Data;
using Microsoft.Data.SqlClient;

namespace practic_ex2
{
    public partial class Form1 : Form
    {

        string connectionString = @"Server=LAPTOP-1COTFGBR\SQLEXPRESS; Database=Problema2; Integrated Security=true; TrustServerCertificate=true;";
        DataSet cds = new DataSet();
        DataSet pds = new DataSet();
        DataSet childds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource parentBS = new BindingSource();
        BindingSource childdBS = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM Artisti", conn);
                    pds.Clear(); cds.Clear();
                    textBox1.DataBindings.Clear(); textBox2.DataBindings.Clear(); textBox3.DataBindings.Clear(); textBox4.DataBindings.Clear();
                    parentAdapter.Fill(pds);
                    parentBS.DataSource = pds.Tables[0];
                    dataGridViewParent.DataSource = parentBS;
                    dataGridViewChild.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string id = dataGridViewParent.Rows[e.RowIndex].Cells[0].Value.ToString();
                childAdapter.SelectCommand = new SqlCommand("SELECT *FROM Melodii where cod_artist=" + id + ";", conn);
                childds.Clear();
                childAdapter.Fill(childds);
                childdBS.DataSource = childds.Tables[0];
                dataGridViewChild.DataSource = childdBS;
            }
        }

        private void dataGridViewChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                textBox1.DataBindings.Clear(); textBox2.DataBindings.Clear(); textBox3.DataBindings.Clear(); textBox4.DataBindings.Clear();

                textBox1.DataBindings.Add("Text", childdBS, "titlu");
                textBox2.DataBindings.Add("Text", childdBS, "an_lansare");
                textBox3.DataBindings.Add("Text", childdBS, "durata");
                textBox4.DataBindings.Add("Text", childdBS, "cod_artist");

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int x;
                    childAdapter.UpdateCommand = new SqlCommand("Update Briose set nume_briosa=@nb, descriere=@d, pret=@p, cod_cofetarie=@c where cod_briosa=@id", conn);
                    childAdapter.UpdateCommand.Parameters.Add("@nb", SqlDbType.VarChar).Value = textBox1.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@d", SqlDbType.VarChar).Value = textBox2.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@p", SqlDbType.Real).Value = textBox3.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@c", SqlDbType.Int).Value = textBox4.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = childds.Tables[0].Rows[dataGridViewChild.CurrentCell.RowIndex][0];
                    conn.Open();
                    x = childAdapter.UpdateCommand.ExecuteNonQuery();
                    conn.Close();
                    if (x >= 1)
                    {
                        MessageBox.Show("Briosa a fost actualizata!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int x;
                DialogResult dr;
                dr = MessageBox.Show("Are you sure you want to delete this briosa?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        childAdapter.DeleteCommand = new SqlCommand("Delete Briose where cod_briosa=@id", conn);
                        childAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = childds.Tables[0].Rows[dataGridViewChild.CurrentCell.RowIndex][0];
                        conn.Open();
                        x = childAdapter.DeleteCommand.ExecuteNonQuery();
                        conn.Close();
                        if (x >= 1)
                        {
                            MessageBox.Show("The briosa has been deleted");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Deletion Aborded");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int x;
                    childAdapter.InsertCommand = new SqlCommand("INSERT INTO Briose VALUES (@nb, @d, @p, @id)", conn);
                    childAdapter.InsertCommand.Parameters.Add("@nb", SqlDbType.VarChar).Value = textBox1.Text;
                    childAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.VarChar).Value = textBox2.Text;
                    childAdapter.InsertCommand.Parameters.Add("@p", SqlDbType.Real).Value = textBox3.Text;
                    childAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int).Value = pds.Tables[0].Rows[dataGridViewParent.CurrentCell.RowIndex][0];
                    conn.Open();
                    x = childAdapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                    if (x >= 1)
                    {
                        MessageBox.Show("The product has been added!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}