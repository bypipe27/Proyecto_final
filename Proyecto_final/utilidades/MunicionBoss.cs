using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.utilidades
{
    public static class municionBoss
    {
        static int ancho = 15;
        static int alto = 15;
        static int cntDisparos = 8;

        public static List<PictureBox> getMunicion(int posIniX, int posIniY)
        {
            List<PictureBox> disparos = new List<PictureBox>();

            for(int i = 0; i < cntDisparos; i++)
            {
                PictureBox municion = new PictureBox
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

                disparos.Add(municion);
            }
            return disparos;
        }

        public static int getAncho()
        {
            return ancho;
        }

        public static int getAlto()
        {
            return alto;
        }

        public static int getCntDisparos() 
        { 
            return cntDisparos; 
        }
    }
}
