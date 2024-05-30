namespace Proyecto_final.forms
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            panel_About = new Panel();
            lbl_TitleHelp = new Label();
            lbl_InfoComandos = new Label();
            lbl_Comandos = new Label();
            lbl_InfoGame = new Label();
            lbl_Objetivo = new Label();
            Btn_Return = new PictureBox();
            panel_About.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Return).BeginInit();
            SuspendLayout();
            // 
            // panel_About
            // 
            panel_About.BackgroundImageLayout = ImageLayout.Zoom;
            panel_About.Controls.Add(lbl_TitleHelp);
            panel_About.Controls.Add(lbl_InfoComandos);
            panel_About.Controls.Add(lbl_Comandos);
            panel_About.Controls.Add(lbl_InfoGame);
            panel_About.Controls.Add(lbl_Objetivo);
            panel_About.Controls.Add(Btn_Return);
            panel_About.Dock = DockStyle.Fill;
            panel_About.Location = new Point(0, 0);
            panel_About.Name = "panel_About";
            panel_About.Size = new Size(800, 450);
            panel_About.TabIndex = 3;
            // 
            // lbl_TitleHelp
            // 
            lbl_TitleHelp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_TitleHelp.AutoSize = true;
            lbl_TitleHelp.BackColor = Color.Transparent;
            lbl_TitleHelp.Font = new Font("Comic Sans MS", 29.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TitleHelp.Location = new Point(247, 9);
            lbl_TitleHelp.Name = "lbl_TitleHelp";
            lbl_TitleHelp.Size = new Size(291, 54);
            lbl_TitleHelp.TabIndex = 11;
            lbl_TitleHelp.Text = "COMO JUGAR";
            // 
            // lbl_InfoComandos
            // 
            lbl_InfoComandos.AutoSize = true;
            lbl_InfoComandos.BackColor = Color.Transparent;
            lbl_InfoComandos.Location = new Point(247, 270);
            lbl_InfoComandos.Name = "lbl_InfoComandos";
            lbl_InfoComandos.Size = new Size(368, 105);
            lbl_InfoComandos.TabIndex = 10;
            lbl_InfoComandos.Text = resources.GetString("lbl_InfoComandos.Text");
            // 
            // lbl_Comandos
            // 
            lbl_Comandos.AutoSize = true;
            lbl_Comandos.BackColor = Color.Transparent;
            lbl_Comandos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_Comandos.ForeColor = Color.Red;
            lbl_Comandos.Location = new Point(40, 246);
            lbl_Comandos.Name = "lbl_Comandos";
            lbl_Comandos.Size = new Size(179, 45);
            lbl_Comandos.TabIndex = 9;
            lbl_Comandos.Text = "Comandos";
            // 
            // lbl_InfoGame
            // 
            lbl_InfoGame.AutoSize = true;
            lbl_InfoGame.BackColor = Color.Transparent;
            lbl_InfoGame.Location = new Point(247, 119);
            lbl_InfoGame.Name = "lbl_InfoGame";
            lbl_InfoGame.Size = new Size(484, 75);
            lbl_InfoGame.TabIndex = 8;
            lbl_InfoGame.Text = resources.GetString("lbl_InfoGame.Text");
            // 
            // lbl_Objetivo
            // 
            lbl_Objetivo.AutoSize = true;
            lbl_Objetivo.BackColor = Color.Transparent;
            lbl_Objetivo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_Objetivo.ForeColor = Color.Red;
            lbl_Objetivo.Location = new Point(40, 95);
            lbl_Objetivo.Name = "lbl_Objetivo";
            lbl_Objetivo.Size = new Size(148, 45);
            lbl_Objetivo.TabIndex = 7;
            lbl_Objetivo.Text = "Objetivo";
            // 
            // Btn_Return
            // 
            Btn_Return.Cursor = Cursors.Hand;
            Btn_Return.Image = (Image)resources.GetObject("Btn_Return.Image");
            Btn_Return.Location = new Point(684, 388);
            Btn_Return.Name = "Btn_Return";
            Btn_Return.Size = new Size(100, 50);
            Btn_Return.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Return.TabIndex = 6;
            Btn_Return.TabStop = false;
            Btn_Return.Click += Btn_Return_Click;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_About);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Help";
            Text = "Help";
            panel_About.ResumeLayout(false);
            panel_About.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Return).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_About;
        private Label lbl_TitleHelp;
        private Label lbl_InfoComandos;
        private Label lbl_Comandos;
        private Label lbl_InfoGame;
        private Label lbl_Objetivo;
        private PictureBox Btn_Return;
    }
}