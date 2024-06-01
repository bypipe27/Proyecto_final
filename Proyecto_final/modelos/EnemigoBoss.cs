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
            Image.FromFile("..\\..\\..\\Resources\\Nave_boss.png"),
            80,
            54,
            10,
            20,
            10)
        {
            this.Name = "NaveBoss";
        }

        public int velocidadBoss()
        {
            return velMovimiento;
        }

        public int getVidas()
        {
        return vidas; 
        }

        public void restarVida()
        {
            this.vidas--;
        }

        public int getPuntos()
        {
            return puntos;
        }
    }
}
