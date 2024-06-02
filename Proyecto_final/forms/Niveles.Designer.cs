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
            pictureBox1 = new PictureBox();
            Btn_Level1 = new PictureBox();
            Btn_NextLevel = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Level1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_NextLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.naev;
            pictureBox1.Location = new Point(522, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Btn_Level1
            // 
            Btn_Level1.Cursor = Cursors.Hand;
            Btn_Level1.Image = Properties.Resources.level_11;
            Btn_Level1.Location = new Point(187, 68);
            Btn_Level1.Name = "Btn_Level1";
            Btn_Level1.Size = new Size(203, 137);
            Btn_Level1.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Level1.TabIndex = 1;
            Btn_Level1.TabStop = false;
            // 
            // Btn_NextLevel
            // 
            Btn_NextLevel.Cursor = Cursors.Hand;
            Btn_NextLevel.Image = Properties.Resources.next_level;
            Btn_NextLevel.Location = new Point(187, 279);
            Btn_NextLevel.Name = "Btn_NextLevel";
            Btn_NextLevel.Size = new Size(203, 119);
            Btn_NextLevel.SizeMode = PictureBoxSizeMode.StretchImage;
            Btn_NextLevel.TabIndex = 2;
            Btn_NextLevel.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.nave2;
            pictureBox2.Location = new Point(522, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Niveles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 32, 40);
            BackgroundImage = Properties.Resources.galaxia;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(Btn_NextLevel);
            Controls.Add(Btn_Level1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Niveles";
            Text = "Niveles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Level1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_NextLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Btn_Level1;
        private PictureBox Btn_NextLevel;
        private PictureBox pictureBox2;
    }
}