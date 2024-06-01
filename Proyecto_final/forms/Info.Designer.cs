namespace Proyecto_final
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            lbl_InfoObjetivo = new Label();
            lbl_InfoComandos = new Label();
            lbl_Comandos = new Label();
            lbl_Objetivo = new Label();
            lbl_About = new Label();
            SuspendLayout();
            // 
            // lbl_InfoObjetivo
            // 
            lbl_InfoObjetivo.AutoSize = true;
            lbl_InfoObjetivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_InfoObjetivo.ForeColor = SystemColors.ControlLightLight;
            lbl_InfoObjetivo.Location = new Point(187, 142);
            lbl_InfoObjetivo.Name = "lbl_InfoObjetivo";
            lbl_InfoObjetivo.Size = new Size(492, 75);
            lbl_InfoObjetivo.TabIndex = 11;
            lbl_InfoObjetivo.Text = resources.GetString("lbl_InfoObjetivo.Text");
            // 
            // lbl_InfoComandos
            // 
            lbl_InfoComandos.AutoSize = true;
            lbl_InfoComandos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_InfoComandos.ForeColor = SystemColors.ControlLightLight;
            lbl_InfoComandos.Location = new Point(187, 263);
            lbl_InfoComandos.Name = "lbl_InfoComandos";
            lbl_InfoComandos.Size = new Size(374, 90);
            lbl_InfoComandos.TabIndex = 9;
            lbl_InfoComandos.Text = resources.GetString("lbl_InfoComandos.Text");
            // 
            // lbl_Comandos
            // 
            lbl_Comandos.AutoSize = true;
            lbl_Comandos.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_Comandos.ForeColor = Color.DarkOrange;
            lbl_Comandos.Location = new Point(28, 245);
            lbl_Comandos.Name = "lbl_Comandos";
            lbl_Comandos.Size = new Size(153, 37);
            lbl_Comandos.TabIndex = 9;
            lbl_Comandos.Text = "Comandos";
            // 
            // lbl_Objetivo
            // 
            lbl_Objetivo.AutoSize = true;
            lbl_Objetivo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbl_Objetivo.ForeColor = Color.DarkOrange;
            lbl_Objetivo.Location = new Point(28, 124);
            lbl_Objetivo.Name = "lbl_Objetivo";
            lbl_Objetivo.Size = new Size(128, 37);
            lbl_Objetivo.TabIndex = 8;
            lbl_Objetivo.Text = "Objetivo";
            // 
            // lbl_About
            // 
            lbl_About.AutoSize = true;
            lbl_About.Font = new Font("Segoe UI", 29F, FontStyle.Bold);
            lbl_About.ForeColor = SystemColors.ControlLightLight;
            lbl_About.Location = new Point(241, 18);
            lbl_About.Name = "lbl_About";
            lbl_About.Size = new Size(279, 52);
            lbl_About.TabIndex = 7;
            lbl_About.Text = "COMO JUGAR";
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(29, 32, 40);
            ClientSize = new Size(743, 406);
            Controls.Add(lbl_InfoObjetivo);
            Controls.Add(lbl_InfoComandos);
            Controls.Add(lbl_Comandos);
            Controls.Add(lbl_Objetivo);
            Controls.Add(lbl_About);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Info";
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_InfoObjetivo;
        private Label lbl_InfoComandos;
        private Label lbl_Comandos;
        private Label lbl_Objetivo;
        private Label lbl_About;
    }
}