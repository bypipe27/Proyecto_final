namespace Proyecto_final
{
    partial class GameOver
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            pictureBox1 = new PictureBox();
            timerTransicionVenPpal = new System.Windows.Forms.Timer(components);
            Btn_Cerrar = new PictureBox();
            BarraTitle = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            BarraTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1016, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timerTransicionVenPpal
            // 
            timerTransicionVenPpal.Enabled = true;
            timerTransicionVenPpal.Interval = 5000;
            timerTransicionVenPpal.Tick += tiempoEsperaTransisionAVenPpal;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.Image = Properties.Resources.boton_cerrar;
            Btn_Cerrar.ImeMode = ImeMode.NoControl;
            Btn_Cerrar.Location = new Point(979, 7);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(25, 25);
            Btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar.TabIndex = 0;
            Btn_Cerrar.TabStop = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // BarraTitle
            // 
            BarraTitle.BackColor = Color.DarkCyan;
            BarraTitle.Controls.Add(Btn_Cerrar);
            BarraTitle.Dock = DockStyle.Top;
            BarraTitle.Location = new Point(0, 0);
            BarraTitle.Name = "BarraTitle";
            BarraTitle.Size = new Size(1016, 38);
            BarraTitle.TabIndex = 4;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(1016, 600);
            Controls.Add(BarraTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameOver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            BarraTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerTransicionVenPpal;
        public PictureBox Btn_Cerrar;
        private Panel BarraTitle;
    }
}