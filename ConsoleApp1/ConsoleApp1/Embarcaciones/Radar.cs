using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Radar : Embarcacion
    {
        public int[] posicion;
        public Radar(string name, int lifePoints)
        {
            Name = "Radar";
            LifePoints = 1;
        }
    }
}
