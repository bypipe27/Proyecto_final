using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.modelos
{
    internal class NaveJugador : Nave
    {

        public NaveJugador() : base(
            Image.FromFile("..\\..\\..\\recursos\\nave_jugador.png"),
            61,
            71,
            3,
            10)
        {
            this.Name = "NaveJugador";

            
        }

        public int velocidadMovNaveJugador()
        {
            return velMovimiento;
        }

    }
}
