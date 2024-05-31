using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final.modelos
{
    internal class NaveEnemiga:Nave
    {
        public NaveEnemiga(Image naveEnemiga, int Ancho, int alto, int vidas, int velocidad) : base(
           naveEnemiga,
           Ancho,
           alto,
           vidas,
           velocidad)
        {
        }
    }
}
