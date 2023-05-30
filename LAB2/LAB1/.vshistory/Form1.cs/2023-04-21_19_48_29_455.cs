using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace LAB1
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
            
        }

        private void disp_only_cat_Click(object sender, EventArgs e)
        {
            
        }


        private void dataGridViewParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void update_prod_Click(object sender, EventArgs e)
        {
            try
            {
                string update = ConfigurationManager.AppSettings["UpdateQuery"];
                SqlCommand cmd = new SqlCommand(update, connection);
                for (int i = 0; i < nr; i++)
                {
                    cmd.Parameters.AddWithValue(paramsNames[i], textBoxes[i].Text);
                }
                cmd.Parameters.AddWithValue("@id", (int)dataGridViewChild.CurrentRow.Cells[0].Value);
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                daChild.Fill(dataSet);
                connection.Close();
                MessageBox.Show("Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }

        }

        private void delete_prod_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = ConfigurationManager.AppSettings["DeleteChild"];
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.AddWithValue("@id", (int)dataGridViewChild.CurrentRow.Cells[0].Value);
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                cmd.ExecuteNonQuery();
                daChild.Fill(dataSet);
                connection.Close();
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }
        }

        private void add_prod_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into " + childTableName + " ( " + ConfigurationManager.AppSettings["ChildLabelNames"] + " ) values ( " + columnNamesInsertParameters + " )", connection);
                for (int i = 0; i < nr; i++)
                {
                    cmd.Parameters.AddWithValue(paramsNames[i], textBoxes[i].Text);
                }
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                daChild.Fill(dataSet);
                connection.Close();
                MessageBox.Show("Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }

        }

        private void afisare_produse_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}