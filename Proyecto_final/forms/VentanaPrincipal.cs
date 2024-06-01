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
        
    }
}
