using Proyecto_final.modelos;

namespace Proyecto_final.forms
{
    partial class VentanaJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaJuego));
            lblPuntaje = new Label();
            timerFlujoDisparos = new System.Windows.Forms.Timer(components);
            timerMovJugador = new System.Windows.Forms.Timer(components);
            timerSpawnEnemigos = new System.Windows.Forms.Timer(components);
            timerGatilloMinions = new System.Windows.Forms.Timer(components);
            lblVidas = new Label();
            timerMovMiniosYDisp = new System.Windows.Forms.Timer(components);
            timerMovInicialBoss = new System.Windows.Forms.Timer(components);
            timerMovBoss = new System.Windows.Forms.Timer(components);
            timerGatilloBoss = new System.Windows.Forms.Timer(components);
            timerDisparosBoss = new System.Windows.Forms.Timer(components);
            lblVidaBoss = new Label();
            timergarbageCollector = new System.Windows.Forms.Timer(components);
            BarraTitle = new Panel();
            pictureBox1 = new PictureBox();
            Btn_Restaurar = new PictureBox();
            Btn_Maximizar = new PictureBox();
            Btn_Minimizar = new PictureBox();
            Btn_Cerrar = new PictureBox();
            BarraTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // lblPuntaje
            // 
            resources.ApplyResources(lblPuntaje, "lblPuntaje");
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.ForeColor = SystemColors.GrayText;
            lblPuntaje.Name = "lblPuntaje";
            // 
            // timerFlujoDisparos
            // 
            timerFlujoDisparos.Interval = 80;
            timerFlujoDisparos.Tick += timerDisparosJugador;
            // 
            // timerMovJugador
            // 
            timerMovJugador.Tick += timerFlujoDeMovJug;
            // 
            // timerSpawnEnemigos
            // 
            timerSpawnEnemigos.Interval = 1000;
            timerSpawnEnemigos.Tick += TimerFlujoaparicionEnemigos;
            // 
            // timerGatilloMinions
            // 
            timerGatilloMinions.Interval = 1500;
            timerGatilloMinions.Tick += timerAccionamientoDisparoMinions;
            // 
            // lblVidas
            // 
            resources.ApplyResources(lblVidas, "lblVidas");
            lblVidas.BackColor = Color.Transparent;
            lblVidas.ForeColor = SystemColors.GrayText;
            lblVidas.Name = "lblVidas";
            // 
            // timerMovMiniosYDisp
            // 
            timerMovMiniosYDisp.Interval = 200;
            timerMovMiniosYDisp.Tick += timerFlujoMovMinionsYProyectiles;
            // 
            // timerMovInicialBoss
            // 
            timerMovInicialBoss.Tick += timerFlujoInicialMovBoss;
            // 
            // timerMovBoss
            // 
            timerMovBoss.Interval = 2000;
            timerMovBoss.Tick += timerFlujoMovBoss;
            // 
            // timerGatilloBoss
            // 
            timerGatilloBoss.Interval = 1500;
            timerGatilloBoss.Tick += timerAccionmientoDisparosBoss;
            // 
            // timerDisparosBoss
            // 
            timerDisparosBoss.Interval = 200;
            timerDisparosBoss.Tick += timerFlujoDisparosBoss;
            // 
            // lblVidaBoss
            // 
            resources.ApplyResources(lblVidaBoss, "lblVidaBoss");
            lblVidaBoss.BackColor = Color.Transparent;
            lblVidaBoss.ForeColor = Color.Red;
            lblVidaBoss.Name = "lblVidaBoss";
            // 
            // timergarbageCollector
            // 
            timergarbageCollector.Interval = 4000;
            timergarbageCollector.Tick += accionamientoGarbageCollector;
            // 
            // BarraTitle
            // 
            BarraTitle.BackColor = Color.DarkCyan;
            BarraTitle.Controls.Add(pictureBox1);
            BarraTitle.Controls.Add(Btn_Restaurar);
            BarraTitle.Controls.Add(Btn_Maximizar);
            BarraTitle.Controls.Add(Btn_Minimizar);
            BarraTitle.Controls.Add(Btn_Cerrar);
            resources.ApplyResources(BarraTitle, "BarraTitle");
            BarraTitle.Name = "BarraTitle";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.boton_cerrar;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += Btn_Cerrar_Click;
            // 
            // Btn_Restaurar
            // 
            resources.ApplyResources(Btn_Restaurar, "Btn_Restaurar");
            Btn_Restaurar.Cursor = Cursors.Hand;
            Btn_Restaurar.Image = Properties.Resources.restaurar;
            Btn_Restaurar.Name = "Btn_Restaurar";
            Btn_Restaurar.TabStop = false;
            // 
            // Btn_Maximizar
            // 
            resources.ApplyResources(Btn_Maximizar, "Btn_Maximizar");
            Btn_Maximizar.Cursor = Cursors.Hand;
            Btn_Maximizar.Image = Properties.Resources.maximizar;
            Btn_Maximizar.Name = "Btn_Maximizar";
            Btn_Maximizar.TabStop = false;
            // 
            // Btn_Minimizar
            // 
            resources.ApplyResources(Btn_Minimizar, "Btn_Minimizar");
            Btn_Minimizar.Cursor = Cursors.Hand;
            Btn_Minimizar.Image = Properties.Resources.minimizar;
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.TabStop = false;
            // 
            // Btn_Cerrar
            // 
            resources.ApplyResources(Btn_Cerrar, "Btn_Cerrar");
            Btn_Cerrar.Cursor = Cursors.Hand;
            Btn_Cerrar.Image = Properties.Resources.boton_cerrar;
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.TabStop = false;
            // 
            // VentanaJuego
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BarraTitle);
            Controls.Add(lblVidaBoss);
            Controls.Add(lblVidas);
            Controls.Add(lblPuntaje);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaJuego";
            KeyDown += keyDownAction;
            KeyUp += keyUpAction;
            BarraTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPuntaje;
        private System.Windows.Forms.Timer timerFlujoDisparos;
        private System.Windows.Forms.Timer timerMovJugador;
        private System.Windows.Forms.Timer timerSpawnEnemigos;
        private System.Windows.Forms.Timer timerGatilloMinions;
        private Label lblVidas;
        private System.Windows.Forms.Timer timerMovMiniosYDisp;
        private System.Windows.Forms.Timer timerMovInicialBoss;
        private System.Windows.Forms.Timer timerGatilloBoss;
        private System.Windows.Forms.Timer timerMovBoss;
        private System.Windows.Forms.Timer timerDisparosBoss;
        private Label lblVidaBoss;
        private System.Windows.Forms.Timer timergarbageCollector;
        private Panel BarraTitle;
        private PictureBox Btn_Restaurar;
        private PictureBox Btn_Maximizar;
        private PictureBox Btn_Minimizar;
        private PictureBox Btn_Cerrar;
        private PictureBox pictureBox1;
    }
}