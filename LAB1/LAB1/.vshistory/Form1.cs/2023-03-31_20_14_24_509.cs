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







        
    }
}