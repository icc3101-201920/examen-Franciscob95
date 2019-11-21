using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reparador : Embarcacion, IMetodos
    {
        private int[,] posicion;
        public Reparador()
        {
            Name = "Reparador";
            LifePoints = 2;
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
            Console.WriteLine("Desea posicionar horizontal o vertical? (H o V)");
            string dir = Console.ReadLine();

            if (dir == "H")
            {
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 10; j++)
                    {
                        if ((i == cooX) & (j == cooY))
                        {
                            posicion[i, j] = 1;
                            if ((i < 9) & (i > 1))
                            {
                                posicion[i + 1, j] = posicion[i + 2, j] = 1;
                            }
                            else
                            {
                                posicion[i - 1, j] = posicion[i - 2, j] = 1;
                            }
                        }
                    }
                }
            }
            if (dir == "V")
            {
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 10; j++)
                    {
                        if ((i == cooX) & (j == cooY))
                        {
                            if ((i == cooX) & (j == cooY))
                            {
                                posicion[i, j] = 1;
                                if ((j < 9) & (j > 1))
                                {
                                    posicion[i, j + 1] = posicion[i, j + 2] = 1;
                                }
                                else
                                {
                                    posicion[i, j - 1] = posicion[i, j - 2] = 1;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

