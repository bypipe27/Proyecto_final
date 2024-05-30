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
            Btn_Return = new PictureBox();
            lbl_TitleHelp = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lbl_Objetivo = new Label();
            lbl_InfoGame = new Label();
            lbl_Comandos = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Btn_Return).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Return
            // 
            Btn_Return.Cursor = Cursors.Hand;
            Btn_Return.Image = (Image)resources.GetObject("Btn_Return.Image");
            Btn_Return.Location = new Point(688, 288);
            Btn_Return.Name = "Btn_Return";
            Btn_Return.Size = new Size(100, 50);
            Btn_Return.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Return.TabIndex = 0;
            Btn_Return.TabStop = false;
            // 
            // lbl_TitleHelp
            // 
            lbl_TitleHelp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_TitleHelp.AutoSize = true;
            lbl_TitleHelp.BackColor = Color.Transparent;
            lbl_TitleHelp.Font = new Font("Comic Sans MS", 29.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_TitleHelp.Location = new Point(258, 24);
            lbl_TitleHelp.Name = "lbl_TitleHelp";
            lbl_TitleHelp.Size = new Size(291, 54);
            lbl_TitleHelp.TabIndex = 1;
            lbl_TitleHelp.Text = "COMO JUGAR";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_TitleHelp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lbl_Comandos);
            panel2.Controls.Add(lbl_InfoGame);
            panel2.Controls.Add(lbl_Objetivo);
            panel2.Controls.Add(Btn_Return);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 350);
            panel2.TabIndex = 3;
            // 
            // lbl_Objetivo
            // 
            lbl_Objetivo.AutoSize = true;
            lbl_Objetivo.BackColor = Color.Transparent;
            lbl_Objetivo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_Objetivo.ForeColor = Color.Red;
            lbl_Objetivo.Location = new Point(128, 3);
            lbl_Objetivo.Name = "lbl_Objetivo";
            lbl_Objetivo.Size = new Size(170, 45);
            lbl_Objetivo.TabIndex = 1;
            lbl_Objetivo.Text = "OBJETIVO";
            lbl_Objetivo.Click += label1_Click;
            // 
            // lbl_InfoGame
            // 
            lbl_InfoGame.AutoSize = true;
            lbl_InfoGame.BackColor = Color.Transparent;
            lbl_InfoGame.Location = new Point(302, 61);
            lbl_InfoGame.Name = "lbl_InfoGame";
            lbl_InfoGame.Size = new Size(484, 75);
            lbl_InfoGame.TabIndex = 2;
            lbl_InfoGame.Text = resources.GetString("lbl_InfoGame.Text");
            lbl_InfoGame.Click += lbl_InfoGame_Click;
            // 
            // lbl_Comandos
            // 
            lbl_Comandos.AutoSize = true;
            lbl_Comandos.BackColor = Color.Transparent;
            lbl_Comandos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_Comandos.ForeColor = Color.Red;
            lbl_Comandos.Location = new Point(128, 167);
            lbl_Comandos.Name = "lbl_Comandos";
            lbl_Comandos.Size = new Size(179, 45);
            lbl_Comandos.TabIndex = 3;
            lbl_Comandos.Text = "Comandos";
            lbl_Comandos.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(302, 212);
            label3.Name = "label3";
            label3.Size = new Size(368, 105);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Help";
            Text = "Help";
            ((System.ComponentModel.ISupportInitialize)Btn_Return).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Btn_Return;
        private Label lbl_TitleHelp;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_Objetivo;
        private Label lbl_InfoGame;
        private Label lbl_Comandos;
        private Label label3;
    }
}