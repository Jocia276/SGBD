using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=LAPTOP-1COTFGBR\SQLEXPRESS; Database=MagazinAlimentar; Integrated Security=true; TrustServerCertificate=true;";
        DataSet ds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
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
                    conn.Close();
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int x;
                    childAdapter.UpdateCommand = new SqlCommand("Update Produs set denumire=@f, pret=@l, id_cat=@i where id_produs=@id", conn);
                    childAdapter.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar).Value = denum_tb.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@l", SqlDbType.Int).Value = pret_tb.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@l", SqlDbType.Int).Value = idcat_tb.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables["Produs"].Rows[childBS.Position][0];
                    conn.Open();
                    x = childAdapter.UpdateCommand.ExecuteNonQuery();
                    conn.Close();
                    if (x >= 1)
                    {
                        MessageBox.Show("The record has been updated");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void display_cat_Click(object sender, EventArgs e)
        {
            intx;
            da.UpdateCommand = newSqlCommand("Update Contacts set FIRSTNAME=@f, LASTNAME=@l where ID=@id", cs);
            da.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar).Value = txtFirstName.Text;
            da.UpdateCommand.Parameters.Add("@l", SqlDbType.VarChar).Value = txtLastName.Text;
            da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables[0].Rows[bs.Position][0];
            cs.Open();
            x = da.UpdateCommand.ExecuteNonQuery();
            cs.Close();
            if (x >= 1)
            {
                MessageBox.Show("The record has been updated");
            }
        }
    }
}