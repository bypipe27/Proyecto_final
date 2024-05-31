using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.utilidades
{
    public static class MunicionMinion
    {
        static int ancho = 10;
        static int alto = 20;
        
        public static PictureBox getMunicion()
        {
            PictureBox municion = new PictureBox
            {
                Image = Image.FromFile("..\\..\\..\\recursos\\nave_boss1.png"),
                Size = new System.Drawing.Size(ancho,alto),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 2,
                TabStop = false,
                Visible = false
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
