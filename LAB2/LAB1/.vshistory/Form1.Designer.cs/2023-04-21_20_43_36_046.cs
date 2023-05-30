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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridViewChild = new DataGridView();
            dataGridViewParent = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            delete_prod = new Button();
            update_prod = new Button();
            afisare_produse = new Button();
            disp_only_cat = new Button();
            panel2 = new Panel();
            add_prod = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewChild
            // 
            dataGridViewChild.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewChild.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewChild.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewChild.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewChild.Location = new Point(29, 73);
            dataGridViewChild.Margin = new Padding(3, 2, 3, 2);
            dataGridViewChild.Name = "dataGridViewChild";
            dataGridViewChild.RowHeadersWidth = 51;
            dataGridViewChild.RowTemplate.Height = 29;
            dataGridViewChild.Size = new Size(579, 316);
            dataGridViewChild.TabIndex = 0;
            // 
            // dataGridViewParent
            // 
            dataGridViewParent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridViewParent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewParent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParent.Location = new Point(709, 73);
            dataGridViewParent.Margin = new Padding(3, 2, 3, 2);
            dataGridViewParent.Name = "dataGridViewParent";
            dataGridViewParent.RowHeadersWidth = 51;
            dataGridViewParent.RowTemplate.Height = 29;
            dataGridViewParent.Size = new Size(611, 316);
            dataGridViewParent.TabIndex = 1;
            dataGridViewParent.CellClick += dataGridViewParent_CellClick;
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
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // delete_prod
            // 
            delete_prod.BackColor = Color.Plum;
            delete_prod.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            delete_prod.Location = new Point(966, 397);
            delete_prod.Margin = new Padding(3, 2, 3, 2);
            delete_prod.Name = "delete_prod";
            delete_prod.Size = new Size(131, 29);
            delete_prod.TabIndex = 6;
            delete_prod.Text = "DELETE";
            delete_prod.UseVisualStyleBackColor = false;
            delete_prod.Click += delete_prod_Click;
            // 
            // update_prod
            // 
            update_prod.BackColor = Color.Plum;
            update_prod.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            update_prod.Location = new Point(1112, 396);
            update_prod.Margin = new Padding(3, 2, 3, 2);
            update_prod.Name = "update_prod";
            update_prod.Size = new Size(131, 31);
            update_prod.TabIndex = 7;
            update_prod.Text = "UPDATE";
            update_prod.UseVisualStyleBackColor = false;
            update_prod.Click += update_prod_Click;
            // 
            // afisare_produse
            // 
            afisare_produse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            afisare_produse.BackColor = Color.Plum;
            afisare_produse.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            afisare_produse.ForeColor = SystemColors.ActiveCaptionText;
            afisare_produse.Location = new Point(29, 393);
            afisare_produse.Margin = new Padding(3, 2, 3, 2);
            afisare_produse.Name = "afisare_produse";
            afisare_produse.Size = new Size(145, 33);
            afisare_produse.TabIndex = 9;
            afisare_produse.Text = "SHOW ALL";
            afisare_produse.UseVisualStyleBackColor = false;
            afisare_produse.Click += afisare_produse_Click;
            // 
            // disp_only_cat
            // 
            disp_only_cat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            disp_only_cat.BackColor = Color.Plum;
            disp_only_cat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            disp_only_cat.ForeColor = SystemColors.ActiveCaptionText;
            disp_only_cat.Location = new Point(1199, 28);
            disp_only_cat.Margin = new Padding(3, 2, 3, 2);
            disp_only_cat.Name = "disp_only_cat";
            disp_only_cat.Size = new Size(121, 33);
            disp_only_cat.TabIndex = 18;
            disp_only_cat.Text = "CONNECT";
            disp_only_cat.UseVisualStyleBackColor = false;
            disp_only_cat.Click += disp_only_cat_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(201, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 205);
            panel2.TabIndex = 19;
            // 
            // add_prod
            // 
            add_prod.Location = new Point(1171, 480);
            add_prod.Name = "add_prod";
            add_prod.Size = new Size(94, 29);
            add_prod.TabIndex = 20;
            add_prod.Text = "addProd";
            add_prod.UseVisualStyleBackColor = true;
            add_prod.Click += add_prod_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightPink;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1372, 649);
            Controls.Add(add_prod);
            Controls.Add(panel2);
            Controls.Add(disp_only_cat);
            Controls.Add(update_prod);
            Controls.Add(label2);
            Controls.Add(delete_prod);
            Controls.Add(label1);
            Controls.Add(dataGridViewParent);
            Controls.Add(dataGridViewChild);
            Controls.Add(afisare_produse);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "CRUD APPLICATION";
            TransparencyKey = Color.Silver;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewParent;
        private Label label1;
        private Label label2;
        private Button delete_prod;
        private Button update_prod;
        private Button afisare_produse;
        private Button disp_only_cat;
        public DataGridView dataGridViewChild;
        private Panel panel2;
        private Button add_prod;
    }
}