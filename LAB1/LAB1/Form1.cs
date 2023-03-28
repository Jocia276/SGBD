using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=LAPTOP-1COTFGBR\SQLEXPRESS; Database=MagazinAlimentar; Integrated Security=true; TrustServerCertificate=true;";
        DataSet cds = new DataSet();
        DataSet pds = new DataSet();
        DataSet ds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void display_cat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    ds.Clear(); cds.Clear(); ds.Relations.Clear();
                    parentAdapter.SelectCommand = new SqlCommand("SELECT *FROM Categorie;", conn);
                    childAdapter.SelectCommand = new SqlCommand("SELECT *FROM Produs;", conn);
                    parentAdapter.Fill(ds, "Categorie");
                    childAdapter.Fill(ds, "Produs");
                    DataColumn parentColumn = ds.Tables["Categorie"].Columns["id_categorie"];
                    DataColumn childColumn = ds.Tables["Produs"].Columns["id_cat"];
                    DataRelation relation = new DataRelation("FK_Categorie_Produs", parentColumn, childColumn);
                    ds.Relations.Add(relation);
                    parentBS.DataSource = ds.Tables["Categorie"];
                    dataGridViewCategorie.DataSource = parentBS;
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "FK_Categorie_Produs";
                    dataGridViewProdus.DataSource = childBS;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void afisare_produse_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn1 = new SqlConnection(connectionString))
                {
                    cds.Clear();
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Produs;", conn1);
                    childAdapter.Fill(cds, "Produs");
                    childBS.DataSource = cds.Tables["Produs"];
                    dataGridViewProdus.DataSource = childBS;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_prod_Click(object sender, EventArgs e)
        {

        }

        private void update_prod_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}