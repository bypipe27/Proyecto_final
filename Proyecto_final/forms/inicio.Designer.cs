namespace Proyecto_final
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            nombre_juego = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nombre_juego).BeginInit();
            SuspendLayout();
            // 
            // nombre_juego
            // 
            nombre_juego.BackColor = Color.Transparent;
            nombre_juego.BackgroundImage = Properties.Resources.Fondo_inicio;
            nombre_juego.Image = (Image)resources.GetObject("nombre_juego.Image");
            nombre_juego.InitialImage = Properties.Resources.Fondo_inicio;
            nombre_juego.Location = new Point(216, 12);
            nombre_juego.Name = "nombre_juego";
            nombre_juego.Size = new Size(307, 143);
            nombre_juego.SizeMode = PictureBoxSizeMode.StretchImage;
            nombre_juego.TabIndex = 10;
            nombre_juego.TabStop = false;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(743, 406);
            Controls.Add(nombre_juego);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "inicio";
            Text = "incio";
            ((System.ComponentModel.ISupportInitialize)nombre_juego).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox nombre_juego;
    }
}