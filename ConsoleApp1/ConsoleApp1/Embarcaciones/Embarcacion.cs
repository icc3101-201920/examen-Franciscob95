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

        public void A_Normal(int [,] enemy)
        {
            int i, j;
            Console.WriteLine("Indique la posicion X donde quiere atacar: ");
            int cooX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indique la posicion Y donde quiere atacar: ");
            int cooY = Convert.ToInt32(Console.ReadLine());

            if (enemy[cooX, cooY] == 1)
            {
                Console.WriteLine("Fuego");
            }
            else
            {
                Console.WriteLine("Agua");
            }
        }
    }
}
