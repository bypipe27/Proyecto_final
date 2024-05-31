using Proyecto_final.modelos;

namespace Proyecto_final.forms
{
    partial class VentanaPruebas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPruebas));
            fontDialog1 = new FontDialog();
            lblPuntaje = new Label();
            timerFlujoDisparos = new System.Windows.Forms.Timer(components);
            timerMovJugador = new System.Windows.Forms.Timer(components);
            timerSpawnEnemigos = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblPuntaje
            // 
            resources.ApplyResources(lblPuntaje, "lblPuntaje");
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.ForeColor = SystemColors.MenuHighlight;
            lblPuntaje.Name = "lblPuntaje";
            // 
            // timerFlujoDisparos
            // 
            timerFlujoDisparos.Interval = 200;
            timerFlujoDisparos.Tick += timerDisparos;
            // 
            // timerMovJugador
            // 
            timerMovJugador.Tick += timerFlujoDeMovJug;
            // 
            // timerSpawnEnemigos
            // 
            timerSpawnEnemigos.Interval = 2000;
            timerSpawnEnemigos.Tick += TimerFlujoaparicionEnemigos;
            // 
            // VentanaPruebas
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblPuntaje);
            Name = "VentanaPruebas";
            KeyDown += keyDownAction;
            KeyUp += keyUpAction;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private Label lblPuntaje;
        private System.Windows.Forms.Timer timerFlujoDisparos;
        private System.Windows.Forms.Timer timerMovJugador;
        private System.Windows.Forms.Timer timerSpawnEnemigos;
    }
}