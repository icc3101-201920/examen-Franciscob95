using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Embarcacion
    {
        protected string name;
        protected int lifePoints;

        public Embarcacion()
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int LifePoints
        {
            get
            {
                return this.lifePoints;
            }
            set
            {
                this.lifePoints = value;
            }
        }
        private void Posicionar(int[,] pos)
        {
            int i, j;
            Console.Write("Indique la posicion donde quiere ubicar su embarcación: ");
            for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 10; j++)
                    {
                        pos[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
        }
    }
}
