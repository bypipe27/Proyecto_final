using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;



namespace Proyecto_final.forms
{
    public partial class VentanaPrincipal : Form
    {
        private VentanaJuego consola_juego;
        private SoundPlayer Musicplayer;

        //private GameOver gameOver;
        public VentanaPrincipal()
        {
            InitializeComponent();
            abrirForm(new Inicio());
            if(File.Exists(@"Resources/Musica_fondo.wav"))
            {
                Musicplayer = new SoundPlayer(@"Resources/Musica_fondo.wav");
                Musicplayer.PlayLooping();
            }
            else
            {
                MessageBox.Show("No se encontro el archivo de musica");
            }
        }

        private void abrirFormJuego()
        {

            consola_juego = new VentanaJuego(this);
            consola_juego.MinimumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            consola_juego.MaximumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            consola_juego.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            consola_juego.Show();
            this.Hide();
            

        }

        private void abrirForm(Form formhija)
        {
            if (this.logo_juego.Controls.Count > 0)
            {
                this.logo_juego.Controls.RemoveAt(0);
            }
                Form form = formhija;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.logo_juego.Controls.Add(form);
                this.logo_juego.Tag = form;
                form.Show();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Maximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Btn_Maximizar.Visible = false;
            Btn_Restaurar.Visible = true;
        }

        private void Btn_Restaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btn_Restaurar.Visible = false;
            Btn_Maximizar.Visible = true;
        }

        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Start_Click_1(object sender, EventArgs e)  //  BOTON START
        {
            abrirFormJuego();
        }

        private void Btn_About_Click(object sender, EventArgs e)//  BOTON ABOUT
        {
            abrirForm(new Info());
        }

        private void pictureBox2_Click(object sender, EventArgs e)// VENTANA EMERGENTE
        {
            DialogResult result = MessageBox.Show("Deseas Salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)   // IMAGEN COMO UN BOTON (INICIO)
        {
            abrirForm(new Inicio());
        }

    }
}
