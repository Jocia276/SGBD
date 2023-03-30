using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LAB1
{
    public partial class Form2 : Form
    {
        string connectionString = @"Server=LAPTOP-1COTFGBR\SQLEXPRESS; Database=MagazinAlimentar; Integrated Security=true; TrustServerCertificate=true;";
        DataSet cds = new DataSet();
        DataSet pds = new DataSet();
        DataSet ds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();
        int rowIndex;
        Form1 f11;
        public Form2()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection conn1 = new SqlConnection(connectionString))
                {
                    ds.Clear();
                    parentAdapter.SelectCommand = new SqlCommand("SELECT id_categorie, nume FROM Categorie;", conn1);
                    parentAdapter.Fill(ds, "Categorie");
                    parentBS.DataSource = ds.Tables["Categorie"];
                    dataGridViewCat.DataSource = parentBS;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void save_button_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {

        //            //int x;
        //            childAdapter.UpdateCommand = new SqlCommand("Update Produs set denumire=@f, pret=@l, id_cat=@i where id_produs=@id", conn);
        //            childAdapter.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar).Value = denumire_txt.Text;
        //            childAdapter.UpdateCommand.Parameters.Add("@l", SqlDbType.Int).Value = pret_txt.Text;
        //            childAdapter.UpdateCommand.Parameters.Add("@i", SqlDbType.Int).Value = id_cat_txt.Text;
        //            childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables["Produs"].Columns["id_produs"];
        //            conn.Open();
        //            childAdapter.UpdateCommand.ExecuteNonQuery();
        //            conn.Close();
        //            //if (x >= 1)
        //            //{
        //            //    MessageBox.Show("The record has been updated");
        //            //}
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    this.Hide();
        //    Form1 f1 = new Form1();
        //    f1.ShowDialog();
        //    this.Close();
        //}

        private void save_button_Click(object sender, EventArgs e)
        {
            string denum_noua = denumire_txt.Text;
            int pret_nou = Convert.ToInt32(pret_txt.Text);
            int id_cat_nou = Convert.ToInt32(id_cat_txt.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                //int x;
                childAdapter.UpdateCommand = new SqlCommand("Update Produs set denumire=@f, pret=@l, id_cat=@i where id_produs=@id", conn);
                childAdapter.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar).Value = denumire_txt.Text;
                childAdapter.UpdateCommand.Parameters.Add("@l", SqlDbType.Int).Value = pret_txt.Text;
                childAdapter.UpdateCommand.Parameters.Add("@i", SqlDbType.Int).Value = id_cat_txt.Text;
                childAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = ds.Tables["Produs"].Rows[rowIndex];
                conn.Open();
                childAdapter.UpdateCommand.ExecuteNonQuery();
                conn.Close();
                //if (x >= 1)
                //{
                //    MessageBox.Show("The record has been updated");
                //}
            }
        }

        public Form2(Form1 f11, int rowIndex, string denumire_prod, int pret_prod, int id_cat)
        {
            InitializeComponent();
            this.f11 = f11;
            this.rowIndex = rowIndex;

            denumire_txt.Text = denumire_prod;
            pret_txt.Text = pret_prod.ToString();
            id_cat_txt.Text = id_cat.ToString();

        }
    }
}
