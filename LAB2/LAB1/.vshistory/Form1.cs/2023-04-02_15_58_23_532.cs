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
        DataSet cds = new DataSet();
        DataSet pds = new DataSet();
        DataSet childds = new DataSet();
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
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open(); denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
            //        parentAdapter.SelectCommand = new SqlCommand("SELECT *FROM Categorie;", conn);
            //        childAdapter.SelectCommand = new SqlCommand("SELECT *FROM Produs;", conn);
            //        parentAdapter.Fill(ds, "Categorie");
            //        childAdapter.Fill(ds, "Produs");
            //        DataColumn parentColumn = ds.Tables["Categorie"].Columns["id_categorie"];
            //        DataColumn childColumn = ds.Tables["Produs"].Columns["id_cat"];
            //        DataRelation relation = new DataRelation("FK_Categorie_Produs", parentColumn, childColumn);
            //        ds.Relations.Add(relation);
            //        parentBS.DataSource = ds.Tables["Categorie"];
            //        dataGridViewCategorie.DataSource = parentBS;
            //        childBS.DataSource = parentBS;
            //        childBS.DataMember = "FK_Categorie_Produs";
            //        dataGridViewProdus.DataSource = childBS;
            //        denum_tb.DataBindings.Add("Text", childBS, "denumire");
            //        pret_tb.DataBindings.Add("Text", childBS, "pret");
            //        idcat_tb.DataBindings.Add("Text", childBS, "id_cat");
            //        conn.Close();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void display_cat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
                    parentAdapter.SelectCommand = new SqlCommand("SELECT *FROM Categorie;", conn);
                    childAdapter.SelectCommand = new SqlCommand("SELECT *FROM Produs;", conn);
                    ds.Clear();
                    parentAdapter.Fill(ds, "Categorie");
                    childAdapter.Fill(ds, "Produs");
                    DataColumn parentColumn = ds.Tables["Categorie"].Columns["id_categorie"];
                    DataColumn childColumn = ds.Tables["Produs"].Columns["id_cat"];
                    ds.Relations.Clear();
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

        private void afisare_produse_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Produs", conn);
                    cds.Clear();
                    childAdapter.Fill(cds, "Produs");
                    childBS.DataSource = cds.Tables[0];
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
                    childAdapter.UpdateCommand.Parameters.Add("@i", SqlDbType.Int).Value = idcat_tb.Text;
                    childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = childds.Tables[0].Rows[dataGridViewProdus.CurrentCell.RowIndex][0];
                    conn.Open();
                    x = childAdapter.UpdateCommand.ExecuteNonQuery();
                    conn.Close();
                    if (x >= 1)
                    {
                        MessageBox.Show("The product has been updated!");
                    }
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
                DialogResult dr;
                dr = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        childAdapter.DeleteCommand = new SqlCommand("Delete Produs where id_produs=@id", conn);
                        childAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = childds.Tables["Produs"].Rows[childBS.Position][0];
                        conn.Open();
                        x = childAdapter.DeleteCommand.ExecuteNonQuery();
                        conn.Close();
                        if (x >= 1)
                        {
                            MessageBox.Show("The product has been deleted");
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

        private void add_prod_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    int x;
                    childAdapter.InsertCommand = new SqlCommand("INSERT INTO Produs VALUES (@d, @p, @id)", conn);
                    childAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.VarChar).Value = car_denum.Text;
                    childAdapter.InsertCommand.Parameters.Add("@p", SqlDbType.Int).Value = cat_pret.Text;
                    childAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables["Categorie"].Rows[parentBS.Position][0];
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

        private void disp_only_cat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM Categorie", conn);
                    pds.Clear(); cds.Clear();
                    denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
                    parentAdapter.Fill(pds);
                    parentBS.DataSource = pds.Tables[0];
                    dataGridViewCategorie.DataSource = parentBS;
                    dataGridViewProdus.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewProdus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();

                denum_tb.DataBindings.Add("Text", childBS, "denumire");
                pret_tb.DataBindings.Add("Text", childBS, "pret");
                idcat_tb.DataBindings.Add("Text", childBS, "id_cat");
                childBS.MoveNext();
            }
        }

        private void dataGridViewCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
               // denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
                string id = dataGridViewCategorie.Rows[e.RowIndex].Cells[0].Value.ToString();
                childAdapter.SelectCommand = new SqlCommand("SELECT *FROM Produs where id_cat=" + id + ";", conn);
                childds.Clear();
                childAdapter.Fill(childds);
                dataGridViewProdus.DataSource = childds.Tables[0];
                childBS.DataSource = childds.Tables[0];
                //denum_tb.DataBindings.Add("Text", childBS, "denumire");
                //pret_tb.DataBindings.Add("Text", childBS, "pret");
                //idcat_tb.DataBindings.Add("Text", childBS, "id_cat");

            }
        }
    }
}