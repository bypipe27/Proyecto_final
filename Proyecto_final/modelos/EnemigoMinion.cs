using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.modelos
{
    internal class EnemigoMinion : NaveEnemiga
    {
        private String orientacionMov;

        protected PictureBox imgMunicion = new PictureBox
        {
            Image = Image.FromFile("..\\..\\..\\recursos\\nave_boss1.png"),
            Size = new System.Drawing.Size(10, 20)
        };

        public EnemigoMinion() : base(
            Image.FromFile("..\\..\\..\\recursos\\nave_boss1.png"),
            80,
            54,
            1,
            10)
        {
            this.Name = "NaveMinion";


        }

        public int velocidadMinion()
        {
            return velMovimiento;
        }

        public PictureBox MunicionMinion()
        {
            return imgMunicion;
        }

        public void setOrientacionMov(String orientacionMov)
        {
            this.orientacionMov = orientacionMov;
        }

        public String getOrientacionMov()
        {
            return orientacionMov;
        }
    }
}
