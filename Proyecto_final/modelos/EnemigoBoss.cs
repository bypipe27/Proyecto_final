using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.modelos
{
    internal class EnemigoBoss : NaveEnemiga
    {

        public EnemigoBoss() : base(
            Image.FromFile("..\\..\\..\\recursos\\nave_boss1.png"),
            80,
            54,
            1,
            10,
            5)
        {
            this.Name = "NaveBoss";
        }

        public int velocidadBoss()
        {
            return velMovimiento;
        }


        public int getPuntos()
        {
            return puntos;
        }
    }
}
