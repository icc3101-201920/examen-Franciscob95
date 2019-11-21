using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    /*Console.Write("element - [{0},{1}] : ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());*/
                    matrix[i, j] = 1;
                }
            }
            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 10; j++)
                    Console.Write("{0}\t", matrix[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
