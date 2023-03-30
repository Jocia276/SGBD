namespace LAB1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            save_button = new Button();
            dataGridViewCat = new DataGridView();
            label3 = new Label();
            denumire_txt = new TextBox();
            pret_txt = new TextBox();
            id_cat_txt = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCat).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 129);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Denumire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 192);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Pret";
            // 
            // save_button
            // 
            save_button.Location = new Point(106, 343);
            save_button.Name = "save_button";
            save_button.Size = new Size(94, 29);
            save_button.TabIndex = 2;
            save_button.Text = "SAVE";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // dataGridViewCat
            // 
            dataGridViewCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCat.Location = new Point(471, 77);
            dataGridViewCat.Name = "dataGridViewCat";
            dataGridViewCat.RowHeadersWidth = 51;
            dataGridViewCat.RowTemplate.Height = 29;
            dataGridViewCat.Size = new Size(301, 295);
            dataGridViewCat.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 261);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Id Categorie";
            // 
            // denumire_txt
            // 
            denumire_txt.Location = new Point(186, 122);
            denumire_txt.Name = "denumire_txt";
            denumire_txt.Size = new Size(125, 27);
            denumire_txt.TabIndex = 5;
            // 
            // pret_txt
            // 
            pret_txt.Location = new Point(186, 189);
            pret_txt.Name = "pret_txt";
            pret_txt.Size = new Size(125, 27);
            pret_txt.TabIndex = 6;
            // 
            // id_cat_txt
            // 
            id_cat_txt.Location = new Point(186, 258);
            id_cat_txt.Name = "id_cat_txt";
            id_cat_txt.Size = new Size(125, 27);
            id_cat_txt.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(471, 37);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 8;
            label4.Text = "CATEGORII";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(id_cat_txt);
            Controls.Add(pret_txt);
            Controls.Add(denumire_txt);
            Controls.Add(label3);
            Controls.Add(dataGridViewCat);
            Controls.Add(save_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button save_button;
        private DataGridView dataGridViewCat;
        private Label label3;
        private TextBox denumire_txt;
        private TextBox pret_txt;
        private TextBox id_cat_txt;
        private Label label4;
    }
}