using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Data.Common;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        DataSet cds = new DataSet();
        DataSet pds = new DataSet();
        DataSet childds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource parentBS = new BindingSource();
        BindingSource childdBS = new BindingSource();

        string ChildTableName = ConfigurationManager.AppSettings["ChildTableName"];
        string ChildColumnNames = ConfigurationManager.AppSettings["ChildColumnNames"];
        string ColumnNamesInsertParameters = ConfigurationManager.AppSettings["ColumnNamesInsertParameters"];
        List<string> ColumnNamesList = new List<string>(ConfigurationManager.AppSettings["ColumnNames"].Split(','));
        SqlCommand cmd = new SqlCommand("INSERT INTO " + ChildTableName + " (" + ChildColumnNames + ") VALUES (" + ColumnNamesInsertParameters + ")", conn);
                    foreach (string column in ColumnNamesList)
                    {
                        System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)panel2.Controls[column];
        cmd.Parameters.AddWithValue("@" + column, textBox.Text);
                    }

    public Form1()
        {
            InitializeComponent();
        }

        private void disp_only_cat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string select = ConfigurationSettings.AppSettings["selectP"];
                    parentAdapter.SelectCommand = new SqlCommand(select, conn);
                    pds.Clear(); cds.Clear();
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


        private void dataGridViewCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string id = dataGridViewCategorie.Rows[e.RowIndex].Cells[0].Value.ToString();
                string select = ConfigurationSettings.AppSettings["selectC"];
                childAdapter.SelectCommand = new SqlCommand(select + id, conn);
                childds.Clear();
                childAdapter.Fill(childds);
                childdBS.DataSource = childds.Tables[0];
                dataGridViewProdus.DataSource = childdBS;
            }
        }

        private void dataGridViewProdus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();

                //denum_tb.DataBindings.Add("Text", childdBS, "denumire");
                //pret_tb.DataBindings.Add("Text", childdBS, "pret");
                //idcat_tb.DataBindings.Add("Text", childdBS, "id_cat");

            }
        }

        private void update_prod_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //{
                    //    int x;
                    //    childAdapter.UpdateCommand = new SqlCommand("Update Produs set denumire=@f, pret=@l, id_cat=@i where id_produs=@id", conn);
                    //    childAdapter.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar).Value = denum_tb.Text;
                    //    childAdapter.UpdateCommand.Parameters.Add("@l", SqlDbType.Int).Value = pret_tb.Text;
                    //    childAdapter.UpdateCommand.Parameters.Add("@i", SqlDbType.Int).Value = idcat_tb.Text;
                    //    childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = childds.Tables[0].Rows[dataGridViewProdus.CurrentCell.RowIndex][0];
                    //    conn.Open();
                    //    x = childAdapter.UpdateCommand.ExecuteNonQuery();
                    //    conn.Close();
                    //    if (x >= 1)
                    //    {
                    //        MessageBox.Show("The product has been updated!");
                    //    }
                    //}

                    
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
                        childAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = childds.Tables[0].Rows[dataGridViewProdus.CurrentCell.RowIndex][0];
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
                    //childAdapter.InsertCommand.Parameters.Add("@d", SqlDbType.VarChar).Value = car_denum.Text;
                    //childAdapter.InsertCommand.Parameters.Add("@p", SqlDbType.Int).Value = cat_pret.Text;
                    childAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int).Value = pds.Tables[0].Rows[dataGridViewCategorie.CurrentCell.RowIndex][0];
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

        private void afisare_produse_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   // denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Produs", conn);
                    cds.Clear(); childds.Clear();
                    childAdapter.Fill(cds, "Produs");
                    childdBS.DataSource = cds.Tables[0];
                    dataGridViewProdus.DataSource = childdBS;

                    //denum_tb.DataBindings.Add("Text", childdBS, "denumire");
                    //pret_tb.DataBindings.Add("Text", childdBS, "pret");
                    //idcat_tb.DataBindings.Add("Text", childdBS, "id_cat");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}