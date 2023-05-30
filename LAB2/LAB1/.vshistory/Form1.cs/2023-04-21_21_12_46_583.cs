using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace LAB1
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();
        private string childTableName = ConfigurationManager.AppSettings["ChildTableName"];
        private string columnNamesInsertParameters = ConfigurationManager.AppSettings["ColumnNamesInsertParameters"];
        private List<string> columnNames = new List<string>(ConfigurationManager.AppSettings["ChildLabelNames"].Split(','));
        private List<string> paramsNames = new List<string>(ConfigurationManager.AppSettings["ColumnNamesInsertParameters"].Split(','));
        private List<string> columnInitiate = new List<string>(ConfigurationManager.AppSettings["ChildTextBoxContent"].Split(','));
        private SqlConnection connection = new SqlConnection(GetConnectionString());
        private int nr = Convert.ToInt32(ConfigurationManager.AppSettings["ChildNumberOfColumns"]);
        private TextBox[] textBoxes;
        private Label[] labels;


        public Form1()
        {
            InitializeComponent();

            textBoxes = new TextBox[nr];
            labels = new Label[nr];

            for (int i = 0; i < nr; i++)
            {
                textBoxes[i] = new TextBox();
                textBoxes[i].Text = columnInitiate[i];
                panel2.Controls.Add(textBoxes[i]);
                textBoxes[i].Location = new Point(250, i*75+20);
                labels[i] = new Label();
                labels[i].Text = columnNames[i];
                labels[i].Location = new Point(110, i*75+20);

                panel2.Controls.Add(labels[i]);
            }

            dataGridViewParent.SelectionChanged += new EventHandler(LoadChildren);
            dataGridViewChild.SelectionChanged += new EventHandler(LoadInformation);
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["cn"].ConnectionString.ToString();
        }

        private void LoadInformation(object sender, EventArgs e)
        {
            LoadInformation();
        }

        private void LoadInformation()
        {
            for (int i = 0; i < nr; i++)
                textBoxes[i].Text = Convert.ToString(dataGridViewChild.CurrentRow.Cells[i + 1].Value);
        }

        private void LoadChildren(object sender, EventArgs e)
        {
            LoadChildren();
        }

        private void LoadChildren()
        {
            int id_cat = (int)dataGridViewParent.CurrentRow.Cells[0].Value;
            string select = ConfigurationManager.AppSettings["SelectChild"];
            SqlCommand cmd = new SqlCommand(select, connection);
            cmd.Parameters.AddWithValue("@id_cat", id_cat);
            SqlDataAdapter daChild = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            daChild.Fill(dataSet);
            dataGridViewChild.DataSource = dataSet.Tables[0];
        }

        private void disp_only_cat_Click(object sender, EventArgs e)
        {
            string select = ConfigurationSettings.AppSettings["SelectParent"];
            da.SelectCommand = new SqlCommand(select, connection);
            ds.Clear();
            da.Fill(ds);
            dataGridViewParent.DataSource = ds.Tables[0];
        }

        private void update_prod_Click(object sender, EventArgs e)
        {
            try
            {
                string update = ConfigurationManager.AppSettings["UpdateQuery"];
                SqlCommand cmd = new SqlCommand(update, connection);
                for (int i = 0; i < nr; i++)
                {
                    cmd.Parameters.AddWithValue(paramsNames[i], textBoxes[i].Text);
                }
                cmd.Parameters.AddWithValue("@id", (int)dataGridViewChild.CurrentRow.Cells[0].Value);
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                daChild.Fill(dataSet);
                connection.Close();
                MessageBox.Show("Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }

        }

        private void delete_prod_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = ConfigurationManager.AppSettings["DeleteChild"];
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.AddWithValue("@id", (int)dataGridViewChild.CurrentRow.Cells[0].Value);
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                cmd.ExecuteNonQuery();
                daChild.Fill(dataSet);
                connection.Close();
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }
        }

        private void add_prod_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into " + childTableName + " values ( " + columnNamesInsertParameters + " )", connection);
                for (int i = 0; i < nr; i++)
                {
                    cmd.Parameters.AddWithValue(paramsNames[i], textBoxes[i].Text);
                }
                SqlDataAdapter daChild = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                connection.Open();
                daChild.Fill(dataSet);
                connection.Close();
                MessageBox.Show("Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                connection.Close();
            }
        }


    }
}