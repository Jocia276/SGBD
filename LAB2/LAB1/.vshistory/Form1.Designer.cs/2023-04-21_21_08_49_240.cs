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
            dataGridViewChild = new DataGridView();
            dataGridViewParent = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            delete_prod = new Button();
            update_prod = new Button();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewChild.DefaultCellStyle = dataGridViewCellStyle1;
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
            delete_prod.Location = new Point(858, 441);
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
            update_prod.Location = new Point(858, 512);
            update_prod.Margin = new Padding(3, 2, 3, 2);
            update_prod.Name = "update_prod";
            update_prod.Size = new Size(131, 31);
            update_prod.TabIndex = 7;
            update_prod.Text = "UPDATE";
            update_prod.UseVisualStyleBackColor = false;
            update_prod.Click += update_prod_Click;
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
            panel2.Location = new Point(29, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 205);
            panel2.TabIndex = 19;
            // 
            // add_prod
            // 
            add_prod.BackColor = Color.Plum;
            add_prod.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            add_prod.Location = new Point(858, 583);
            add_prod.Name = "add_prod";
            add_prod.Size = new Size(131, 29);
            add_prod.TabIndex = 20;
            add_prod.Text = "ADD";
            add_prod.UseVisualStyleBackColor = false;
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
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "CRUD APPLICATION";
            TransparencyKey = Color.Silver;
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
        private Button disp_only_cat;
        public DataGridView dataGridViewChild;
        private Panel panel2;
        private Button add_prod;
    }
}