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
        public GameOver(VentanaPrincipal principal)
        {

            InitializeComponent();
            this.principal = principal;
            timerTransicionVenPpal.Enabled = true;
            timerTransicionVenPpal.Start();
        }

        private void tiempoEsperaTransisionAVenPpal(object sender, EventArgs e)
        {
            
            timerTransicionVenPpal.Enabled = false;
            timerTransicionVenPpal.Dispose();
            principal.Show();
            this.Controls.Clear();
            base.Dispose();
            GC.Collect();
            this.Close();
            
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void definirMensaje(Image image)
        {
            pictureBox1.Image = image;
        }

    }
}
