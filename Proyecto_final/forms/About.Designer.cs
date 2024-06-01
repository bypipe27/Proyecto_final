namespace Proyecto_final.forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pictureBox1 = new PictureBox();
            lbl_About = new Label();
            lbl_Objetivo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_About
            // 
            lbl_About.AutoSize = true;
            lbl_About.Font = new Font("Segoe UI", 29F, FontStyle.Bold);
            lbl_About.ForeColor = SystemColors.ControlLightLight;
            lbl_About.Location = new Point(256, 23);
            lbl_About.Name = "lbl_About";
            lbl_About.Size = new Size(279, 52);
            lbl_About.TabIndex = 1;
            lbl_About.Text = "COMO JUGAR";
            // 
            // lbl_Objetivo
            // 
            lbl_Objetivo.AutoSize = true;
            lbl_Objetivo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_Objetivo.ForeColor = Color.DarkOrange;
            lbl_Objetivo.Location = new Point(43, 128);
            lbl_Objetivo.Name = "lbl_Objetivo";
            lbl_Objetivo.Size = new Size(128, 37);
            lbl_Objetivo.TabIndex = 2;
            lbl_Objetivo.Text = "Objetivo";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 32, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Objetivo);
            Controls.Add(lbl_About);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_About;
        private Label lbl_Objetivo;
    }
}