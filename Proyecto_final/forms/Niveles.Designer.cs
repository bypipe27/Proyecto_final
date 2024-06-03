namespace Proyecto_final
{
    partial class Niveles
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
            Fondo_Niveles = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            Btn_NextLevel = new PictureBox();
            Btn_Level1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Fondo_Niveles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_NextLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Level1).BeginInit();
            SuspendLayout();
            // 
            // Fondo_Niveles
            // 
            Fondo_Niveles.Dock = DockStyle.Fill;
            Fondo_Niveles.Image = Properties.Resources.galaxia;
            Fondo_Niveles.Location = new Point(0, 0);
            Fondo_Niveles.Name = "Fondo_Niveles";
            Fondo_Niveles.Size = new Size(800, 450);
            Fondo_Niveles.SizeMode = PictureBoxSizeMode.StretchImage;
            Fondo_Niveles.TabIndex = 0;
            Fondo_Niveles.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.naev;
            pictureBox3.Location = new Point(511, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nave2;
            pictureBox2.Location = new Point(518, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Btn_NextLevel
            // 
            Btn_NextLevel.Cursor = Cursors.Hand;
            Btn_NextLevel.Image = Properties.Resources.next_level;
            Btn_NextLevel.Location = new Point(183, 271);
            Btn_NextLevel.Name = "Btn_NextLevel";
            Btn_NextLevel.Size = new Size(203, 119);
            Btn_NextLevel.SizeMode = PictureBoxSizeMode.StretchImage;
            Btn_NextLevel.TabIndex = 6;
            Btn_NextLevel.TabStop = false;
            // 
            // Btn_Level1
            // 
            Btn_Level1.Cursor = Cursors.Hand;
            Btn_Level1.Image = Properties.Resources.level_11;
            Btn_Level1.Location = new Point(183, 60);
            Btn_Level1.Name = "Btn_Level1";
            Btn_Level1.Size = new Size(203, 137);
            Btn_Level1.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Level1.TabIndex = 5;
            Btn_Level1.TabStop = false;
            // 
            // Niveles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 32, 40);
            BackgroundImage = Properties.Resources.galaxia;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Btn_NextLevel);
            Controls.Add(Btn_Level1);
            Controls.Add(Fondo_Niveles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Niveles";
            Text = "Niveles";
            ((System.ComponentModel.ISupportInitialize)Fondo_Niveles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_NextLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Level1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Fondo_Niveles;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox Btn_NextLevel;
        private PictureBox Btn_Level1;
    }
}