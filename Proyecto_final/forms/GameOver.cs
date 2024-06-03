using Proyecto_final.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class GameOver : Form
    {
        VentanaPrincipal principal;
        public GameOver(Image msj)
        {

            InitializeComponent();
            pictureBox1.Image = msj;
            timerTransicionVenPpal.Start();
        }

        private void tiempoEsperaTransisionAVenPpal(object sender, EventArgs e)
        {
            timerTransicionVenPpal.Stop();
            timerTransicionVenPpal.Enabled = false;
            timerTransicionVenPpal.Dispose();
            this.Controls.Clear();
            principal = new VentanaPrincipal();
            principal.MinimumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            principal.MaximumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            principal.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            principal.Show();
            base.Dispose();
            GC.Collect();
            this.Close();
            
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
