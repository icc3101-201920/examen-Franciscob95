using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Radar : Embarcacion, IMetodos
    {
        private int[,] posicion;
        public Radar()
        {
            Name = "Radar";
            LifePoints = 1;
            posicion = new int[10, 10];
        }
        public int[,] Posicion
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

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if ((i == cooX) & (j == cooY))
                    {
                        if ((i == cooX) & (j == cooY))
                        {
                            posicion[i, j] = 1;
                        }
                    }
                }
            }
            
        }
    }
}

