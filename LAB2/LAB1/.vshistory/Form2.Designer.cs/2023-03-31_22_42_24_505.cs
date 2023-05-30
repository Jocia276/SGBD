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
            denumire_f2 = new TextBox();
            pret_f2 = new TextBox();
            SuspendLayout();
            // 
            // denumire_f2
            // 
            denumire_f2.Location = new Point(71, 127);
            denumire_f2.Name = "denumire_f2";
            denumire_f2.Size = new Size(220, 27);
            denumire_f2.TabIndex = 0;
            // 
            // pret_f2
            // 
            pret_f2.Location = new Point(71, 180);
            pret_f2.Name = "pret_f2";
            pret_f2.Size = new Size(220, 27);
            pret_f2.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pret_f2);
            Controls.Add(denumire_f2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox denumire_f2;
        private TextBox pret_f2;
    }
}