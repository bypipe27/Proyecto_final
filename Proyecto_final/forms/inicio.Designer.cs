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
            Fondo_Inicio = new PictureBox();
            nombre_juego = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Fondo_Inicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nombre_juego).BeginInit();
            SuspendLayout();
            // 
            // Fondo_Inicio
            // 
            Fondo_Inicio.Dock = DockStyle.Fill;
            Fondo_Inicio.Image = Properties.Resources.Fondo_inicio;
            Fondo_Inicio.Location = new Point(0, 0);
            Fondo_Inicio.Margin = new Padding(3, 4, 3, 4);
            Fondo_Inicio.Name = "Fondo_Inicio";
            Fondo_Inicio.Size = new Size(929, 701);
            Fondo_Inicio.SizeMode = PictureBoxSizeMode.StretchImage;
            Fondo_Inicio.TabIndex = 11;
            Fondo_Inicio.TabStop = false;
            // 
            // nombre_juego
            // 
            nombre_juego.BackColor = Color.Transparent;
            nombre_juego.Image = Properties.Resources.Logo_juego;
            nombre_juego.InitialImage = Properties.Resources.Fondo_inicio;
            nombre_juego.Location = new Point(617, 280);
            nombre_juego.Margin = new Padding(3, 4, 3, 4);
            nombre_juego.Name = "nombre_juego";
            nombre_juego.Size = new Size(300, 291);
            nombre_juego.SizeMode = PictureBoxSizeMode.StretchImage;
            nombre_juego.TabIndex = 12;
            nombre_juego.TabStop = false;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(929, 701);
            Controls.Add(nombre_juego);
            Controls.Add(Fondo_Inicio);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "inicio";
            Text = "incio";
            ((System.ComponentModel.ISupportInitialize)Fondo_Inicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nombre_juego).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Fondo_Inicio;
        private PictureBox nombre_juego;
    }
}