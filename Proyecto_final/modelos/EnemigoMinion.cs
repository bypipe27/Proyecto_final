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

        public EnemigoMinion() : base(
            Image.FromFile("..\\..\\..\\recursos\\nave_boss1.png"),
            60,
            40,
            1,
            10,
            5)
        {
            this.Name = "NaveMinion";


        }

        public int velocidadMinion()
        {
            return velMovimiento;
        }

        public void setOrientacionMov(String orientacionMov)
        {
            this.orientacionMov = orientacionMov;
        }

        public String getOrientacionMov()
        {
            return orientacionMov;
        }

        public int getPuntos()
        {
            return puntos;
        }
    }
}
