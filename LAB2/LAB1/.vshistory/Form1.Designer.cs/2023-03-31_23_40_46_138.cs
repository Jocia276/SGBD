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
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorie).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProdus
            // 
            dataGridViewProdus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 2;
            label1.Text = "PRODUSE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(709, 17);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIE";
            // 
            // display_cat
            // 
            display_cat.Location = new Point(1171, 45);
            display_cat.Margin = new Padding(3, 2, 3, 2);
            display_cat.Name = "display_cat";
            display_cat.Size = new Size(149, 24);
            display_cat.TabIndex = 4;
            display_cat.Text = "CONNECT";
            display_cat.UseVisualStyleBackColor = true;
            display_cat.Click += display_cat_Click;
            // 
            // delete_prod
            // 
            delete_prod.Location = new Point(433, 109);
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
            update_prod.Location = new Point(433, 154);
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
            add_prod.Location = new Point(1197, 97);
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
            afisare_produse.Location = new Point(433, 44);
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
            label3.Location = new Point(60, 48);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 10;
            label3.Text = "Denumire";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 116);
            label4.Name = "label4";
            label4.Size = new Size(33, 17);
            label4.TabIndex = 11;
            label4.Text = "Pret";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 165);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 12;
            label5.Text = "Id Categorie";
            // 
            // denum_tb
            // 
            denum_tb.Location = new Point(200, 43);
            denum_tb.Margin = new Padding(3, 2, 3, 2);
            denum_tb.Name = "denum_tb";
            denum_tb.Size = new Size(177, 25);
            denum_tb.TabIndex = 13;
            // 
            // pret_tb
            // 
            pret_tb.Location = new Point(200, 108);
            pret_tb.Margin = new Padding(3, 2, 3, 2);
            pret_tb.Name = "pret_tb";
            pret_tb.Size = new Size(177, 25);
            pret_tb.TabIndex = 14;
            // 
            // idcat_tb
            // 
            idcat_tb.Location = new Point(200, 153);
            idcat_tb.Margin = new Padding(3, 2, 3, 2);
            idcat_tb.Name = "idcat_tb";
            idcat_tb.Size = new Size(177, 25);
            idcat_tb.TabIndex = 15;
            // 
            // car_denum
            // 
            car_denum.Location = new Point(956, 43);
            car_denum.Margin = new Padding(3, 2, 3, 2);
            car_denum.Name = "car_denum";
            car_denum.Size = new Size(177, 25);
            car_denum.TabIndex = 16;
            car_denum.TextChanged += car_denum_TextChanged;
            // 
            // cat_pret
            // 
            cat_pret.Location = new Point(956, 128);
            cat_pret.Margin = new Padding(3, 2, 3, 2);
            cat_pret.Name = "cat_pret";
            cat_pret.Size = new Size(177, 25);
            cat_pret.TabIndex = 17;
            // 
            // disp_only_cat
            // 
            disp_only_cat.Location = new Point(923, 41);
            disp_only_cat.Margin = new Padding(3, 2, 3, 2);
            disp_only_cat.Name = "disp_only_cat";
            disp_only_cat.Size = new Size(197, 24);
            disp_only_cat.TabIndex = 18;
            disp_only_cat.Text = "Display only Categories";
            disp_only_cat.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(car_denum);
            panel1.Controls.Add(cat_pret);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(idcat_tb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(add_prod);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pret_tb);
            panel1.Controls.Add(update_prod);
            panel1.Controls.Add(afisare_produse);
            panel1.Controls.Add(delete_prod);
            panel1.Controls.Add(denum_tb);
            panel1.Location = new Point(2, 449);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 210);
            panel1.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1372, 649);
            Controls.Add(panel1);
            Controls.Add(disp_only_cat);
            Controls.Add(display_cat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewCategorie);
            Controls.Add(dataGridViewProdus);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "CRUD APPLICATION";
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
    }
}