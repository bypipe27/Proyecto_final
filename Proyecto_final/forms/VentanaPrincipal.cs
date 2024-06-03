using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final.forms
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFormJuego(object formhija)
        {
            if ((this.Menu.Controls.Count > 0) && (this.logo_juego.Controls.Count > 0))
            {
                //this.Menu.Controls.Clear();
                /*this.Menu.Controls.RemoveAt(0);
                this.logo_juego.Controls.RemoveAt(0);*/
                //this.panel_Principal.Controls.RemoveAt(0);.

                //  ELIMINAMOS TODOS LOS PANELES Y BOTONES QUE TIENE EL FORM PRINCIPAL
                this.panel_Principal.Controls.Remove(Menu);
                this.panel_Principal.Controls.Remove(logo_juego);
                this.panel_Principal.Controls.Remove(panel2);
                this.panel_Principal.Controls.Remove(panel3);
                this.panel_Principal.Controls.Remove(panel4);

                //  CREAMOS EL OBJETO FORM, DEFINIMOS QUE NO SEA TOPLEVEL
                // LE AGREGAMOS TODO LO DEL JUEGO Y LO MOSTRAMOS



                //this.logo_juego.Controls.Add(form);
                //this.logo_juego.Tag = form;
                //form.ShowDialog();
            }

            Form form = formhija as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel_Principal.Controls.Add(form);
            this.panel_Principal.Tag = form;
            form.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - BarraTitle.Height);
            form.MaximumSize = new Size(this.ClientSize.Width, this.ClientSize.Height - BarraTitle.Height);
            form.Show();

            /*Form form = formhija as Form;
            form.TopLevel = true;
            form.Dock = DockStyle.Fill;
            this.logo_juego.Controls.Add(form);
            this.logo_juego.Tag = form;
            form.Show();*/

        }

        private void abrirForm(object formhija)
        {
            if (this.logo_juego.Controls.Count > 0)
            {
                this.logo_juego.Controls.RemoveAt(0);
                Form form = formhija as Form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.logo_juego.Controls.Add(form);
                this.logo_juego.Tag = form;
                form.Show();

            }
            else if (this.logo_juego.Controls.Count == 0)
            {
                Form form = formhija as Form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.logo_juego.Controls.Add(form);
                this.logo_juego.Tag = form;
                form.Show();
            }
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

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Dynamic_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Start_Click_1(object sender, EventArgs e)  //  BOTON START
        {
            abrirFormJuego(new VentanaPruebas());
        }

        private void Btn_About_Click(object sender, EventArgs e)//  BOTON ABOUT
        {
            abrirForm(new Info());
        }

        private void pictureBox2_Click(object sender, EventArgs e)// VENTANA EMERGENTE
        {
            DialogResult result = MessageBox.Show("¿Deseas Salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_Levels_Click_1(object sender, EventArgs e)
        {
            abrirForm(new Niveles());
        }

        private void Btn_Inicio_Click(object sender, EventArgs e)   // IMAGEN COMO UN BOTON (INICIO)
        {
            abrirForm(new inicio());
        }

        private void logo_juego_Paint(object sender, PaintEventArgs e)
        {
            //Btn_Inicio_Click(null, e);
        }
    }
}
