using Microsoft.Data.SqlClient;
using System.Data;

namespace exam
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=LAPTOP-1COTFGBR\SQLEXPRESS; Database=S12; Integrated Security=true; TrustServerCertificate=true;";
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
                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM TipuriSucuriNaturale", conn);
                    pds.Clear(); cds.Clear();
                    textBox1.DataBindings.Clear(); textBox2.DataBindings.Clear(); textBox3.DataBindings.Clear(); textBox4.DataBindings.Clear(); textBox5.DataBindings.Clear(); textBox6.DataBindings.Clear();
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
                childAdapter.SelectCommand = new SqlCommand("SELECT *FROM SucuriNaturale where TSid=" + id + ";", conn);
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
                textBox1.DataBindings.Clear(); textBox2.DataBindings.Clear(); textBox3.DataBindings.Clear(); textBox4.DataBindings.Clear(); textBox5.DataBindings.Clear(); textBox6.DataBindings.Clear();

                textBox1.DataBindings.Add("Text", childdBS, "Denumire");
                textBox2.DataBindings.Add("Text", childdBS, "Producator");
                textBox3.DataBindings.Add("Text", childdBS, "Gramaj");
                textBox4.DataBindings.Add("Text", childdBS, "Pret");
                textBox5.DataBindings.Add("Text", childdBS, "DataExpirare");
                textBox6.DataBindings.Add("Text", childdBS, "TSid");

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int x;
                    childAdapter.UpdateCommand = new SqlCommand("Update SucuriNaturale set Denumire=@den, Producator=@pr, Gramaj=@gr, pret=@p, DataExpirare=@data, TSid=@c where Sid=@id", conn);
                    childAdapter.UpdateCommand.Parameters.Add("@den", SqlDbType.VarChar).Value = textBox1.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@pr", SqlDbType.VarChar).Value = textBox2.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@gr", SqlDbType.Int).Value = textBox3.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@p", SqlDbType.Int).Value = textBox4.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@data", SqlDbType.Date).Value = textBox5.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@c", SqlDbType.Int).Value = textBox6.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = childds.Tables[0].Rows[dataGridViewChild.CurrentCell.RowIndex][0];
                    conn.Open();
                    x = childAdapter.UpdateCommand.ExecuteNonQuery();
                    conn.Close();
                    if (x >= 1)
                    {
                        MessageBox.Show("Sucul natural a fost actualizat!");
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

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}