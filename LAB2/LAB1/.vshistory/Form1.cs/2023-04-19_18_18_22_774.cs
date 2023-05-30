using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace LAB1
{
    public partial class Form1 : Form
    {
        static string con = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        static string parentName = ConfigurationManager.AppSettings["ParentTableName"];
        static string childName = ConfigurationManager.AppSettings["ChildTableName"];
        static int childNumberOfColumns = int.Parse(ConfigurationManager.AppSettings["ChildNumberOfColumns"]);
        static string insertQuerry = ConfigurationManager.AppSettings["ChildInsertQUERY"];
        static string deleteQuerry = ConfigurationManager.AppSettings["ChildDeleteQUERY"];
        static string updateQuerry = ConfigurationManager.AppSettings["ChildUpdateQUERY"];

        static string childArr = ConfigurationManager.AppSettings["ChildArr"];

        static string childColumnNames = ConfigurationManager.AppSettings["ChildColumnNames"];
        static string childColumnTypes = ConfigurationManager.AppSettings["ChildColumnTypes"];
        static string childToParentID = ConfigurationManager.AppSettings["ChildToParentID"];

        SqlConnection cs = new SqlConnection(con);
        SqlDataAdapter da = new SqlDataAdapter();
        BindingSource bsP = new BindingSource();
        BindingSource bsC = new BindingSource();
        DataSet dsP = new DataSet();
        DataSet dsC = new DataSet();

        TextBox[] textBoxes = new TextBox[childNumberOfColumns];
        Label[] labels = new Label[childNumberOfColumns];


        public Form1()
        {
            InitializeComponent();
            string[] names = childColumnNames.Split(",");
            // starting from 2 
            for (int i = 0; i < childNumberOfColumns; i++)
            {
                labels[i] = new Label();
                textBoxes[i] = new TextBox();


                labels[i].Text = names[i];
                labels[i].Location = new Point(i * 150 + 200, 20);

                textBoxes[i].Text = "";
                textBoxes[i].Location = new Point(i * 150 + 200, 50);
            }
        }

        private void disp_only_cat_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("SELECT * FROM " + parentName, cs);
            dsP.Clear();
            da.Fill(dsP);
            dataGridViewCategorie.DataSource = dsP.Tables[0];
            bsP.DataSource = dsP.Tables[0];
            bsP.MoveLast();
        }


        private void dataGridViewCategorie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCategorie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                return;


            string Id_Meniu = dataGridViewCategorie.Rows[e.RowIndex].Cells[0].Value.ToString();

            da.SelectCommand = new SqlCommand("SELECT * from " + childName +
                    " where " + childName + "." + childToParentID + " = " + Id_Meniu + "; ", cs);
            dsC.Clear();
            da.Fill(dsC);
            dataGridViewProdus.DataSource = dsC.Tables[0];
            bsC.DataSource = dsC.Tables[0];
        }

        private void dataGridViewProdus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void update_prod_Click(object sender, EventArgs e)
        {

            if (dataGridViewProdus.SelectedCells.Count == 0)
            {
                MessageBox.Show("O linie in copil trebuie slectata!");
                return;
            }
            else if (dataGridViewProdus.SelectedCells.Count > 1)
            {
                MessageBox.Show("O singura linie in copil trebuie slectata!");
                return;
            }

            int x;
            da.UpdateCommand = new SqlCommand(updateQuerry, cs);

            da.UpdateCommand.Parameters.Add("@id",
                SqlDbType.Int).Value = dsC.Tables[0].Rows[dataGridViewProdus.CurrentCell.RowIndex][0];

            string[] args = childArr.Split(", ");
            string[] types = childColumnTypes.Split(", ");

            try
            {
                for (int i = 0; i < childNumberOfColumns; i++)
                {
                    switch (types[i])
                    {
                        case "string":
                            da.UpdateCommand.Parameters.Add(args[i + 1], SqlDbType.VarChar).Value = textBoxes[i].Text;
                            break;
                        case "int":
                            da.UpdateCommand.Parameters.Add(args[i + 1], SqlDbType.Int).Value = int.Parse(textBoxes[i].Text);
                            break;
                        case "float":
                            da.UpdateCommand.Parameters.Add(args[i + 1], SqlDbType.Float).Value = float.Parse(textBoxes[i].Text);
                            break;
                    }
                }

                cs.Open();
                x = da.UpdateCommand.ExecuteNonQuery();
                cs.Close();
                dsC.Clear();
                da.Fill(dsC);

                if (x >= 1)
                    MessageBox.Show("The record has been updated");
            }

            catch
            {
                MessageBox.Show("Input gresit!");
            }
        }

        private void delete_prod_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdus.SelectedCells.Count == 0)
            {
                MessageBox.Show("O linie in copil trebuie slectata!");
                return;
            }
            else if (dataGridViewProdus.SelectedCells.Count > 1)
            {
                MessageBox.Show("O singura linie in copil trebuie slectata!");
                return;
            }

            da.DeleteCommand = new SqlCommand(deleteQuerry, cs);

            da.DeleteCommand.Parameters.Add("@id",
                SqlDbType.Int).Value = dsC.Tables[0].Rows[dataGridViewProdus.CurrentCell.RowIndex][0];

            cs.Open();
            da.DeleteCommand.ExecuteNonQuery();
            cs.Close();
            dsC.Clear();
            da.Fill(dsC);

        }

        private void add_prod_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new
                SqlCommand(insertQuerry, cs);
            da.InsertCommand.Parameters.Add("@id",
                SqlDbType.Int).Value = dsP.Tables[dataGridViewCategorie.CurrentCell.ColumnIndex].Rows[dataGridViewCategorie.CurrentCell.RowIndex][0];

            string[] args = childArr.Split(", ");
            string[] types = childColumnTypes.Split(", ");

            try
            {
                for (int i = 0; i < childNumberOfColumns; i++)
                {
                    switch (types[i])
                    {
                        case "string":
                            da.InsertCommand.Parameters.Add(args[i + 1], SqlDbType.VarChar).Value = textBoxes[i].Text;
                            break;
                        case "int":
                            da.InsertCommand.Parameters.Add(args[i + 1], SqlDbType.Int).Value = int.Parse(textBoxes[i].Text);
                            break;
                        case "float":
                            da.InsertCommand.Parameters.Add(args[i + 1], SqlDbType.Float).Value = float.Parse(textBoxes[i].Text);
                            break;
                        default:
                            MessageBox.Show("WTF");
                            break;
                    }
                }

                cs.Open();
                da.InsertCommand.ExecuteNonQuery();
                cs.Close();
                dsC.Clear();
                da.Fill(dsC);
            }

            catch
            {
                MessageBox.Show("Input gresit!");
            }
        }

    private void afisare_produse_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        // denum_tb.DataBindings.Clear(); pret_tb.DataBindings.Clear(); idcat_tb.DataBindings.Clear();
            //        childAdapter.SelectCommand = new SqlCommand("SELECT * FROM Produs", conn);
            //        cds.Clear(); childds.Clear();
            //        childAdapter.Fill(cds, "Produs");
            //        childdBS.DataSource = cds.Tables[0];
            //        dataGridViewProdus.DataSource = childdBS;

            //        //denum_tb.DataBindings.Add("Text", childdBS, "denumire");
            //        //pret_tb.DataBindings.Add("Text", childdBS, "pret");
            //        //idcat_tb.DataBindings.Add("Text", childdBS, "id_cat");
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < childNumberOfColumns; i++)
            {
                this.Controls.Add(labels[i]);
                this.Controls.Add(textBoxes[i]);
            }
        }
    }
}