using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.modelos
{
    internal class EnemigoBoss : NaveEnemiga
    {
        private static int vidaTotal = 50;

        public EnemigoBoss() : base(
            Image.FromFile("..\\..\\..\\Resources\\Nave_boss.png"),
            80,
            54,
            vidaTotal,
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

        public int getVidaTotal()
        {
            return vidaTotal;
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
