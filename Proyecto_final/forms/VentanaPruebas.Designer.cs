﻿using Proyecto_final.modelos;

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
            lblVidas.ForeColor = SystemColors.MenuHighlight;
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
            // VentanaPruebas
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblVidaBoss);
            Controls.Add(lblVidas);
            Controls.Add(lblPuntaje);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentanaPruebas";
            Load += VentanaPruebas_Load;
            KeyDown += keyDownAction;
            KeyUp += keyUpAction;
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


    }
}