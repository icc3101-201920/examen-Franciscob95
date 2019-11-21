using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fragata : Embarcacion
    {
        private int[] posicion;
        public Fragata(string name, int lifePoints, int[] posicion)
        {
            Name = "Fragata";
            LifePoints = 4;
            this.posicion = posicion;
        }
    }
}
