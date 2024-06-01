using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas Salir?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void Btn_Help_Click(object sender, EventArgs e)
        {
            abrirForm(new Info());
            //Info formAbout = new Info();
            //formAbout.ShowDialog();
        }

        private void panel_Dynamic_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            abrirForm(new inicio());
        }

        private void Btn_Levels_Click(object sender, EventArgs e)
        {

        }
    }
}
