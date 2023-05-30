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
        Form1 f1;
        string connectionString = @"Server=LAPTOP-1COTFGBR\SQLEXPRESS; Database=MagazinAlimentar; Integrated Security=true; TrustServerCertificate=true;";
        DataSet ds = new DataSet();
        DataSet cds = new DataSet();
        DataSet pds = new DataSet();
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            denumire_f2.Text = f1.denum_tb.Text;
            pret_f2.Text = f1.pret_tb.Text;
            id_categorie_f2.Text = f1.idcat_tb.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                int x;
                childAdapter.UpdateCommand = new SqlCommand("Update Produs set denumire=@f, pret=@l, id_cat=@i where id_produs=@id", conn);
                childAdapter.UpdateCommand.Parameters.Add("@f", SqlDbType.VarChar).Value = denumire_f2.Text;
                childAdapter.UpdateCommand.Parameters.Add("@l", SqlDbType.Int).Value = pret_f2.Text;
                childAdapter.UpdateCommand.Parameters.Add("@i", SqlDbType.Int).Value = id_categorie_f2.Text;
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
    }
}
