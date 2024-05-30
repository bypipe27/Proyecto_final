using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.modelos
{
    internal class NaveJugador : Nave
    {
        protected PictureBox imgMunicion = new PictureBox
        {
            Image = Image.FromFile("..\\..\\..\\recursos\\nave_jugador.png"),
            Size = new System.Drawing.Size(2, 5),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
            TabIndex = 2,
            TabStop = false,
            Visible = false,
        };

        public NaveJugador() : base(
            Image.FromFile("..\\..\\..\\recursos\\nave_jugador.png"),
            60,
            70,
            3,
            10)
        {
            this.Name = "NaveJugador";

            
        }

        public int velocidadMovNaveJugador()
        {
            return velMovimiento;
        }

        public PictureBox tipoDeMunicion()
        {
            return imgMunicion;
        }
    }
}
