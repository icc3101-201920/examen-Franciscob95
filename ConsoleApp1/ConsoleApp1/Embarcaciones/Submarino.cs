using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Submarino : Embarcacion
    {
        public int[] posicion;
        public Submarino(string name, int lifePoints)
        {
            Name = "Submarino";
            LifePoints = 3;
        }
    }
}
