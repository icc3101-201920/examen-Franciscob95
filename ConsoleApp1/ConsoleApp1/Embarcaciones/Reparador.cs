using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reparador : Embarcacion
    {
        public int[] posicion;
        public Reparador(string name, int lifePoints)
        {
            Name = "Reparador";
            LifePoints = 2;
        }
    }
}
