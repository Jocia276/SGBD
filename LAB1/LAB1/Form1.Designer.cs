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
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorie).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdus
            // 
            dataGridViewProdus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdus.Location = new Point(47, 110);
            dataGridViewProdus.Name = "dataGridViewProdus";
            dataGridViewProdus.RowHeadersWidth = 51;
            dataGridViewProdus.RowTemplate.Height = 29;
            dataGridViewProdus.Size = new Size(579, 371);
            dataGridViewProdus.TabIndex = 0;
            // 
            // dataGridViewCategorie
            // 
            dataGridViewCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategorie.Location = new Point(755, 110);
            dataGridViewCategorie.Name = "dataGridViewCategorie";
            dataGridViewCategorie.RowHeadersWidth = 51;
            dataGridViewCategorie.RowTemplate.Height = 29;
            dataGridViewCategorie.Size = new Size(610, 371);
            dataGridViewCategorie.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 41);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 2;
            label1.Text = "PRODUSE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(755, 41);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIE";
            // 
            // display_cat
            // 
            display_cat.Location = new Point(882, 530);
            display_cat.Name = "display_cat";
            display_cat.Size = new Size(150, 29);
            display_cat.TabIndex = 4;
            display_cat.Text = "DISPLAY";
            display_cat.UseVisualStyleBackColor = true;
            display_cat.Click += display_cat_Click;
            // 
            // delete_prod
            // 
            delete_prod.Location = new Point(256, 530);
            delete_prod.Name = "delete_prod";
            delete_prod.Size = new Size(131, 29);
            delete_prod.TabIndex = 6;
            delete_prod.Text = "DELETE";
            delete_prod.UseVisualStyleBackColor = true;
            delete_prod.Click += delete_prod_Click;
            // 
            // update_prod
            // 
            update_prod.Location = new Point(503, 530);
            update_prod.Name = "update_prod";
            update_prod.Size = new Size(123, 29);
            update_prod.TabIndex = 7;
            update_prod.Text = "UPDATE";
            update_prod.UseVisualStyleBackColor = true;
            update_prod.Click += update_prod_Click;
            // 
            // add_prod
            // 
            add_prod.Location = new Point(1180, 530);
            add_prod.Name = "add_prod";
            add_prod.Size = new Size(94, 29);
            add_prod.TabIndex = 8;
            add_prod.Text = "ADD";
            add_prod.UseVisualStyleBackColor = true;
            // 
            // afisare_produse
            // 
            afisare_produse.Location = new Point(47, 530);
            afisare_produse.Name = "afisare_produse";
            afisare_produse.Size = new Size(94, 29);
            afisare_produse.TabIndex = 9;
            afisare_produse.Text = "DISPLAY";
            afisare_produse.UseVisualStyleBackColor = true;
            afisare_produse.Click += afisare_produse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 692);
            Controls.Add(afisare_produse);
            Controls.Add(add_prod);
            Controls.Add(update_prod);
            Controls.Add(delete_prod);
            Controls.Add(display_cat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewCategorie);
            Controls.Add(dataGridViewProdus);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProdus;
        private DataGridView dataGridViewCategorie;
        private Label label1;
        private Label label2;
        private Button display_cat;
        private Button delete_prod;
        private Button update_prod;
        private Button add_prod;
        private Button afisare_produse;
    }
}