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
                textBox1.DataBindings.Clear(); textBox2.DataBindings.Clear(); textBox3.DataBindings.Clear(); textBox4.DataBindings.Clear();

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

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}