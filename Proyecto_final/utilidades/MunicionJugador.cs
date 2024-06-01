using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.utilidades
{
    public static class MunicionJugador
    {
        static int ancho = 15;
        static int alto = 25;
        
        public static PictureBox getMunicion()
        {
            PictureBox municion = new PictureBox
            {
                Image = Image.FromFile("..\\..\\..\\Resources\\disparo_hero.png"),
                Size = new System.Drawing.Size(ancho,alto),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 2,
                TabStop = false,
                Visible = false,
                BackColor = System.Drawing.Color.Transparent
            };
            return municion;
        }

        public static int getAncho()
        {
            return ancho;
        }

        public static int getAlto()
        {
            return alto;
        }


    }
}
