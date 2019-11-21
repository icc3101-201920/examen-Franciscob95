using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fragata : Embarcacion, IMetodos
    {
        private int[,] posicion;
        /*public Fragata(string name, int lifePoints, int[,] posicion)
        {
            Name = "Fragata";
            LifePoints = 4;
            posicion = new int [10,10];
        }*/
        public Fragata()
        {
            Name = "Fragata";
            LifePoints = 4;
            posicion = new int[10, 10];
        }
        public int [,] Posicion
        {
            get
            {
                return this.posicion;
            }
        }


        public void A_Especial()
        {
            throw new NotImplementedException();
        }

        public void A_Normal()
        {
            throw new NotImplementedException();
        }

        public void Mover()
        {
            throw new NotImplementedException();
        }
    }
}
