﻿namespace Proyecto_final
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            BarraTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BarraTitle
            // 
            BarraTitle.BackColor = Color.DimGray;
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
            Menu.Controls.Add(pictureBox2);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 38);
            Menu.Name = "Menu";
            Menu.Size = new Size(200, 406);
            Menu.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 349);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 406);
            panel1.TabIndex = 2;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 444);
            Controls.Add(panel1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel BarraTitle;
        private Panel Menu;
        private Panel panel1;
        private PictureBox Btn_Cerrar;
        private PictureBox pictureBox2;
        private PictureBox Btn_Minimizar;
        private PictureBox Btn_Restaurar;
        private PictureBox Btn_Maximizar;
    }
}
