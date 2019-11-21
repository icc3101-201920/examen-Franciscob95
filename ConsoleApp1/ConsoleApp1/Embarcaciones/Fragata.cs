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
        private void Posicionar()
        {
            int i, j;
            Console.WriteLine("Indique la posicion X donde quiere ubicar su embarcación: ");
            int cooX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la posicion Y donde quiere ubicar su embarcación: ");
            int cooY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Desea posicionar horizontal o vertical? (H o V)");
            string dir = Console.ReadLine();


            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {

                }
            }
        }
    }
}
