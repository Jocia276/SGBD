using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    ds.Clear(); ds.Relations.Clear();
                    denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();

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
                    denum_tb.DataBindings.Add("Text", childBS, "denumire");
                    pret_tb.DataBindings.Add("Text", childBS, "pret");
                    idcat_tb.DataBindings.Add("Text", childBS, "id_cat");
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
                    cds.Clear(); ds.Relations.Clear();
                    denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Produs;", conn1);
                    childAdapter.Fill(cds, "Produs");
                    childBS.DataSource = cds.Tables["Produs"];
                    dataGridViewProdus.DataSource = childBS;
                    denum_tb.DataBindings.Add("Text", childBS, "denumire");
                    pret_tb.DataBindings.Add("Text", childBS, "pret");
                    idcat_tb.DataBindings.Add("Text", childBS, "id_cat");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disp_only_cat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conne = new SqlConnection(connectionString))
                {
                    pds.Clear(); cds.Clear(); ds.Relations.Clear();
                    denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM Categorie;", conne);
                    parentAdapter.Fill(pds, "Categorie");
                    parentBS.DataSource = pds.Tables["Categorie"];
                    dataGridViewCategorie.DataSource = parentBS;
                    dataGridViewProdus.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_prod_Click(object sender, EventArgs e)
        {

            try
            {
                int x;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    childAdapter.DeleteCommand = new SqlCommand("Delete Produs where id_produs=@id", conn);
                    childAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables["Produs"].Rows[childBS.Position][0];
                    conn.Open();
                    x = childAdapter.DeleteCommand.ExecuteNonQuery();
                    conn.Close();
                    if (x >= 1)
                    {
                        MessageBox.Show("the record has been deleted");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         

        }

        private void update_prod_Click(object sender, EventArgs e)
        {
            try
            {
                int x;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    childAdapter.UpdateCommand = new SqlCommand("UPDATE Produs set denumire=@d, pret=@p, id_cat=@i where id_produs=@id", conn);
                    childAdapter.UpdateCommand.Parameters.Add("@d", SqlDbType.VarChar).Value = denum_tb.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@p", SqlDbType.Int).Value = pret_tb.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@i", SqlDbType.Int).Value = idcat_tb.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables["Produs"].Rows[childBS.Position][0];
                    conn.Open();
                    x = childAdapter.UpdateCommand.ExecuteNonQuery();
                    conn.Close();
                    if (x >= 1)
                    {
                        MessageBox.Show("the record has been updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_prod_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    childAdapter.InsertCommand = new SqlCommand("INSERT INTO Produs VALUES (@d, @p, @id)", conn);
                    childAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.VarChar).Value = car_denum.Text;
                    childAdapter.InsertCommand.Parameters.Add("@p", SqlDbType.Int).Value = cat_pret.Text;
                    childAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables["Categorie"].Rows[parentBS.Position][0];
                    conn.Open();
                    childAdapter.InsertCommand.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}