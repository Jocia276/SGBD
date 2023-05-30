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
        public Form2()
        {
            InitializeComponent();
        }
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
    }
}
