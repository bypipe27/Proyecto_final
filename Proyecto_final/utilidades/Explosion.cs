using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.utilidades
{
    internal class Explosion
    {
        static int ancho = 15;
        static int alto = 15;

        public static PictureBox getExplosion(int posIniX, int posIniY)
        {
            PictureBox Explosion = new PictureBox
            {
                Image = Image.FromFile("..\\..\\..\\Resources\\disparo_boss.png"),
                Size = new System.Drawing.Size(ancho, alto),
                Location = new Point(posIniX, posIniY),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 2,
                TabStop = false,
                Visible = true,
                BackColor = System.Drawing.Color.Transparent
            };

            return Explosion;
        }
    }
}
