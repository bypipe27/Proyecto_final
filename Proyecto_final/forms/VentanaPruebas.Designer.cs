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
            fontDialog1 = new FontDialog();
            lblPuntaje = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblPuntaje
            // 
            lblPuntaje.AutoSize = true;
            lblPuntaje.BackColor = Color.Transparent;
            lblPuntaje.Font = new Font("Bauhaus 93", 20F);
            lblPuntaje.ForeColor = SystemColors.MenuHighlight;
            lblPuntaje.Location = new Point(12, 9);
            lblPuntaje.Name = "lblPuntaje";
            lblPuntaje.Size = new Size(73, 30);
            lblPuntaje.TabIndex = 0;
            lblPuntaje.Text = "0000";
            // 
            // timer1
            // 
            timer1.Interval = 300;
            timer1.Tick += flujoDeTrabajo;
            // 
            // VentanaPruebas
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 461);
            Controls.Add(lblPuntaje);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "VentanaPruebas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentanaPruebas";
            KeyDown += MovimientoNaveJugador;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private Label lblPuntaje;
        private System.Windows.Forms.Timer timer1;
    }
}