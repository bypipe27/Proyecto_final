namespace Proyecto_final
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            BarraTitle = new Panel();
            Btn_Restaurar = new PictureBox();
            Btn_Maximizar = new PictureBox();
            Btn_Minimizar = new PictureBox();
            Btn_Cerrar = new PictureBox();
            Menu = new Panel();
            panel4 = new Panel();
            Btn_About = new Button();
            panel3 = new Panel();
            Btn_Start = new Button();
            panel2 = new Panel();
            Btn_Levels = new Button();
            Btn_Exit = new PictureBox();
            panel_Dynamic = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BarraTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Exit).BeginInit();
            panel_Dynamic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BarraTitle
            // 
            BarraTitle.BackColor = Color.DarkCyan;
            BarraTitle.Controls.Add(Btn_Restaurar);
            BarraTitle.Controls.Add(Btn_Maximizar);
            BarraTitle.Controls.Add(Btn_Minimizar);
            BarraTitle.Controls.Add(Btn_Cerrar);
            BarraTitle.Dock = DockStyle.Top;
            BarraTitle.Location = new Point(0, 0);
            BarraTitle.Name = "BarraTitle";
            BarraTitle.Size = new Size(943, 38);
            BarraTitle.TabIndex = 0;
            // 
            // Btn_Restaurar
            // 
            Btn_Restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Restaurar.Cursor = Cursors.Hand;
            Btn_Restaurar.Image = (Image)resources.GetObject("Btn_Restaurar.Image");
            Btn_Restaurar.Location = new Point(875, 7);
            Btn_Restaurar.Name = "Btn_Restaurar";
            Btn_Restaurar.Size = new Size(25, 25);
            Btn_Restaurar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Restaurar.TabIndex = 5;
            Btn_Restaurar.TabStop = false;
            Btn_Restaurar.Visible = false;
            Btn_Restaurar.Click += Btn_Restaurar_Click_1;
            // 
            // Btn_Maximizar
            // 
            Btn_Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Maximizar.Cursor = Cursors.Hand;
            Btn_Maximizar.Image = (Image)resources.GetObject("Btn_Maximizar.Image");
            Btn_Maximizar.Location = new Point(875, 7);
            Btn_Maximizar.Name = "Btn_Maximizar";
            Btn_Maximizar.Size = new Size(25, 25);
            Btn_Maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Maximizar.TabIndex = 4;
            Btn_Maximizar.TabStop = false;
            Btn_Maximizar.Click += Btn_Maximizar_Click_1;
            // 
            // Btn_Minimizar
            // 
            Btn_Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.Image = (Image)resources.GetObject("Btn_Minimizar.Image");
            Btn_Minimizar.Location = new Point(844, 7);
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.Size = new Size(25, 25);
            Btn_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Minimizar.TabIndex = 3;
            Btn_Minimizar.TabStop = false;
            Btn_Minimizar.Click += Btn_Minimizar_Click;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.Image = (Image)resources.GetObject("Btn_Cerrar.Image");
            Btn_Cerrar.Location = new Point(906, 7);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(25, 25);
            Btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar.TabIndex = 0;
            Btn_Cerrar.TabStop = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(29, 32, 40);
            Menu.Controls.Add(panel4);
            Menu.Controls.Add(Btn_About);
            Menu.Controls.Add(panel3);
            Menu.Controls.Add(Btn_Start);
            Menu.Controls.Add(panel2);
            Menu.Controls.Add(Btn_Levels);
            Menu.Controls.Add(Btn_Exit);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 38);
            Menu.Name = "Menu";
            Menu.Size = new Size(200, 406);
            Menu.TabIndex = 1;
            Menu.Paint += Menu_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Location = new Point(0, 245);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 54);
            panel4.TabIndex = 6;
            // 
            // Btn_About
            // 
            Btn_About.AutoSize = true;
            Btn_About.Cursor = Cursors.Hand;
            Btn_About.FlatAppearance.BorderColor = Color.White;
            Btn_About.FlatAppearance.BorderSize = 0;
            Btn_About.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            Btn_About.FlatStyle = FlatStyle.Flat;
            Btn_About.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            Btn_About.ForeColor = Color.Cornsilk;
            Btn_About.Location = new Point(12, 245);
            Btn_About.Name = "Btn_About";
            Btn_About.Size = new Size(192, 54);
            Btn_About.TabIndex = 5;
            Btn_About.Text = "ABOUT";
            Btn_About.UseVisualStyleBackColor = true;
            Btn_About.Click += Btn_Help_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Location = new Point(0, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 54);
            panel3.TabIndex = 4;
            // 
            // Btn_Start
            // 
            Btn_Start.AutoSize = true;
            Btn_Start.Cursor = Cursors.Hand;
            Btn_Start.FlatAppearance.BorderColor = Color.White;
            Btn_Start.FlatAppearance.BorderSize = 0;
            Btn_Start.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            Btn_Start.FlatStyle = FlatStyle.Flat;
            Btn_Start.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            Btn_Start.ForeColor = Color.Cornsilk;
            Btn_Start.Location = new Point(12, 176);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Size = new Size(188, 54);
            Btn_Start.TabIndex = 3;
            Btn_Start.Text = "START";
            Btn_Start.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 54);
            panel2.TabIndex = 2;
            // 
            // Btn_Levels
            // 
            Btn_Levels.AutoSize = true;
            Btn_Levels.Cursor = Cursors.Hand;
            Btn_Levels.FlatAppearance.BorderColor = Color.White;
            Btn_Levels.FlatAppearance.BorderSize = 0;
            Btn_Levels.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            Btn_Levels.FlatStyle = FlatStyle.Flat;
            Btn_Levels.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            Btn_Levels.ForeColor = Color.Cornsilk;
            Btn_Levels.Location = new Point(12, 109);
            Btn_Levels.Name = "Btn_Levels";
            Btn_Levels.Size = new Size(188, 54);
            Btn_Levels.TabIndex = 1;
            Btn_Levels.Text = "NIVELES";
            Btn_Levels.UseVisualStyleBackColor = true;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Btn_Exit.Cursor = Cursors.Hand;
            Btn_Exit.Image = (Image)resources.GetObject("Btn_Exit.Image");
            Btn_Exit.Location = new Point(0, 349);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(76, 54);
            Btn_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Exit.TabIndex = 0;
            Btn_Exit.TabStop = false;
            Btn_Exit.Click += pictureBox2_Click;
            // 
            // panel_Dynamic
            // 
            panel_Dynamic.AutoSize = true;
            panel_Dynamic.BackColor = Color.Transparent;
            panel_Dynamic.BackgroundImage = (Image)resources.GetObject("panel_Dynamic.BackgroundImage");
            panel_Dynamic.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Dynamic.Controls.Add(pictureBox1);
            panel_Dynamic.Controls.Add(pictureBox2);
            panel_Dynamic.Dock = DockStyle.Fill;
            panel_Dynamic.Location = new Point(200, 38);
            panel_Dynamic.Name = "panel_Dynamic";
            panel_Dynamic.Size = new Size(743, 406);
            panel_Dynamic.TabIndex = 2;
            panel_Dynamic.Paint += panel_Dynamic_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(743, 406);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 444);
            Controls.Add(panel_Dynamic);
            Controls.Add(Menu);
            Controls.Add(BarraTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaPrincipal";
            Text = "Form1";
            BarraTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Exit).EndInit();
            panel_Dynamic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitle;
        private Panel Menu;
        private Panel panel_Dynamic;
        private PictureBox Btn_Cerrar;
        private PictureBox Btn_Exit;
        private PictureBox Btn_Minimizar;
        private PictureBox Btn_Restaurar;
        private PictureBox Btn_Maximizar;
        private Button Btn_Levels;
        private Panel panel2;
        private Panel panel4;
        private Button Btn_About;
        private Panel panel3;
        private Button Btn_Start;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
