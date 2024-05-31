using System.Windows.Forms;

namespace Proyecto_final
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
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

        }

        private void panel_Dynamic_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar el GIF desde un archivo
            fondo_inicio.Image = Image.FromFile("C:\\Users\\San\\Documents\\GitHub\\Santiago-POO\\Proyecto_final\\Proyecto_final\\images\\Disparo_prueba_1.gif");

            // Alternativamente, cargar el GIF desde los recursos del proyecto
            // pictureBox1.Image = Properties.Resources.tu_gif;
        }
    }
}
