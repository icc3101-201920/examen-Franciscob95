using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Portaaviones : Embarcacion
    {
        public int[] posicion;
        public Portaaviones(string name, int lifePoints)
        {
            Name = "Portaaviones";
            LifePoints = 5;
        }
    }
}
