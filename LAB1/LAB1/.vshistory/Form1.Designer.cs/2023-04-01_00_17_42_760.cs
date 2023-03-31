namespace LAB1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewProdus = new DataGridView();
            dataGridViewCategorie = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            display_cat = new Button();
            delete_prod = new Button();
            update_prod = new Button();
            add_prod = new Button();
            afisare_produse = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            denum_tb = new TextBox();
            pret_tb = new TextBox();
            idcat_tb = new TextBox();
            car_denum = new TextBox();
            cat_pret = new TextBox();
            disp_only_cat = new Button();
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorie).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProdus
            // 
            dataGridViewCellStyle1.Padding = new Padding(7, 0, 0, 0);
            dataGridViewProdus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProdus.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProdus.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProdus.Location = new Point(29, 73);
            dataGridViewProdus.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProdus.Name = "dataGridViewProdus";
            dataGridViewProdus.RowHeadersWidth = 51;
            dataGridViewProdus.RowTemplate.Height = 29;
            dataGridViewProdus.Size = new Size(579, 316);
            dataGridViewProdus.TabIndex = 0;
            dataGridViewProdus.CellContentClick += dataGridViewProdus_CellContentClick;
            // 
            // dataGridViewCategorie
            // 
            dataGridViewCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategorie.Location = new Point(709, 73);
            dataGridViewCategorie.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCategorie.Name = "dataGridViewCategorie";
            dataGridViewCategorie.RowHeadersWidth = 51;
            dataGridViewCategorie.RowTemplate.Height = 29;
            dataGridViewCategorie.Size = new Size(611, 316);
            dataGridViewCategorie.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleVioletRed;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(145, 31);
            label1.TabIndex = 2;
            label1.Text = "PRODUSE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PaleVioletRed;
            label2.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(709, 30);
            label2.Name = "label2";
            label2.Size = new Size(177, 31);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIE";
            // 
            // display_cat
            // 
            display_cat.BackColor = Color.Plum;
            display_cat.FlatStyle = FlatStyle.Popup;
            display_cat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            display_cat.Location = new Point(1199, 30);
            display_cat.Margin = new Padding(3, 2, 3, 2);
            display_cat.Name = "display_cat";
            display_cat.Size = new Size(121, 31);
            display_cat.TabIndex = 4;
            display_cat.Text = "CONNECT";
            display_cat.UseVisualStyleBackColor = false;
            display_cat.Click += display_cat_Click;
            // 
            // delete_prod
            // 
            delete_prod.Location = new Point(433, 74);
            delete_prod.Margin = new Padding(3, 2, 3, 2);
            delete_prod.Name = "delete_prod";
            delete_prod.Size = new Size(131, 24);
            delete_prod.TabIndex = 6;
            delete_prod.Text = "DELETE";
            delete_prod.UseVisualStyleBackColor = true;
            delete_prod.Click += delete_prod_Click;
            // 
            // update_prod
            // 
            update_prod.Location = new Point(433, 129);
            update_prod.Margin = new Padding(3, 2, 3, 2);
            update_prod.Name = "update_prod";
            update_prod.Size = new Size(131, 24);
            update_prod.TabIndex = 7;
            update_prod.Text = "UPDATE";
            update_prod.UseVisualStyleBackColor = true;
            update_prod.Click += update_prod_Click;
            // 
            // add_prod
            // 
            add_prod.Location = new Point(1225, 74);
            add_prod.Margin = new Padding(3, 2, 3, 2);
            add_prod.Name = "add_prod";
            add_prod.Size = new Size(93, 24);
            add_prod.TabIndex = 8;
            add_prod.Text = "ADD";
            add_prod.UseVisualStyleBackColor = true;
            add_prod.Click += add_prod_Click;
            // 
            // afisare_produse
            // 
            afisare_produse.Location = new Point(515, 393);
            afisare_produse.Margin = new Padding(3, 2, 3, 2);
            afisare_produse.Name = "afisare_produse";
            afisare_produse.Size = new Size(93, 24);
            afisare_produse.TabIndex = 9;
            afisare_produse.Text = "DISPLAY";
            afisare_produse.UseVisualStyleBackColor = true;
            afisare_produse.Click += afisare_produse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(39, 44);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 10;
            label3.Text = "Denumire";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(57, 104);
            label4.Name = "label4";
            label4.Size = new Size(42, 22);
            label4.TabIndex = 11;
            label4.Text = "Pret";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(27, 152);
            label5.Name = "label5";
            label5.Size = new Size(108, 22);
            label5.TabIndex = 12;
            label5.Text = "Id Categorie";
            // 
            // denum_tb
            // 
            denum_tb.BackColor = SystemColors.HighlightText;
            denum_tb.Location = new Point(186, 43);
            denum_tb.Margin = new Padding(3, 2, 3, 2);
            denum_tb.Name = "denum_tb";
            denum_tb.Size = new Size(177, 25);
            denum_tb.TabIndex = 13;
            // 
            // pret_tb
            // 
            pret_tb.Location = new Point(186, 101);
            pret_tb.Margin = new Padding(3, 2, 3, 2);
            pret_tb.Name = "pret_tb";
            pret_tb.Size = new Size(177, 25);
            pret_tb.TabIndex = 14;
            // 
            // idcat_tb
            // 
            idcat_tb.Location = new Point(186, 153);
            idcat_tb.Margin = new Padding(3, 2, 3, 2);
            idcat_tb.Name = "idcat_tb";
            idcat_tb.Size = new Size(177, 25);
            idcat_tb.TabIndex = 15;
            // 
            // car_denum
            // 
            car_denum.Location = new Point(809, 73);
            car_denum.Margin = new Padding(3, 2, 3, 2);
            car_denum.Name = "car_denum";
            car_denum.Size = new Size(177, 25);
            car_denum.TabIndex = 16;
            car_denum.TextChanged += car_denum_TextChanged;
            // 
            // cat_pret
            // 
            cat_pret.Location = new Point(1037, 75);
            cat_pret.Margin = new Padding(3, 2, 3, 2);
            cat_pret.Name = "cat_pret";
            cat_pret.Size = new Size(101, 25);
            cat_pret.TabIndex = 17;
            // 
            // disp_only_cat
            // 
            disp_only_cat.Location = new Point(1123, 393);
            disp_only_cat.Margin = new Padding(3, 2, 3, 2);
            disp_only_cat.Name = "disp_only_cat";
            disp_only_cat.Size = new Size(197, 24);
            disp_only_cat.TabIndex = 18;
            disp_only_cat.Text = "Display only Categories";
            disp_only_cat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(car_denum);
            panel1.Controls.Add(cat_pret);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(idcat_tb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(add_prod);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pret_tb);
            panel1.Controls.Add(update_prod);
            panel1.Controls.Add(delete_prod);
            panel1.Controls.Add(denum_tb);
            panel1.Location = new Point(2, 449);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 210);
            panel1.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(809, 44);
            label7.Name = "label7";
            label7.Size = new Size(87, 22);
            label7.TabIndex = 19;
            label7.Text = "Denumire";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(1037, 46);
            label6.Name = "label6";
            label6.Size = new Size(42, 22);
            label6.TabIndex = 18;
            label6.Text = "Pret";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1372, 649);
            Controls.Add(panel1);
            Controls.Add(disp_only_cat);
            Controls.Add(display_cat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewCategorie);
            Controls.Add(dataGridViewProdus);
            Controls.Add(afisare_produse);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "CRUD APPLICATION";
            TransparencyKey = Color.Silver;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorie).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewCategorie;
        private Label label1;
        private Label label2;
        private Button display_cat;
        private Button delete_prod;
        private Button update_prod;
        private Button add_prod;
        private Button afisare_produse;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox car_denum;
        private TextBox cat_pret;
        private Button disp_only_cat;
        public TextBox denum_tb;
        public TextBox pret_tb;
        public TextBox idcat_tb;
        public DataGridView dataGridViewProdus;
        private Panel panel1;
        private Label label7;
        private Label label6;
    }
}