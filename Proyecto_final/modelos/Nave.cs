using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.modelos
{
    public abstract class Nave : PictureBox
    {
        protected int vidas { get; set; }
        protected int velMovimiento { get; set; }

        protected Nave(Image img, int medidaImgX, int medidaImgY, int vidas, int vel_mov)
        {

            this.vidas = vidas;
            this.velMovimiento = vel_mov;

            this.BackColor = System.Drawing.Color.Transparent;
            this.Image = img;
            this.Size = new System.Drawing.Size(medidaImgX, medidaImgY);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TabIndex = 2;
            this.TabStop = false;
            this.Visible = false;
        }

        public void establecerPosicion(int posicionX, int posicionY)
        {
            this.Location = new System.Drawing.Point(posicionX, posicionY);
        }

    }
}
