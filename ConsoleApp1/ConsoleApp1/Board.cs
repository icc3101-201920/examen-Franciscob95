using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Board
    {
        private int[,] p_board;
        public Board()
        {
            p_board = new int[10, 10];
        }
        public int[,] P_board
        {
            get
            {
                return this.p_board;
            }
        }
        public int [,] GenerarBoard()
        {
            int i, j;
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < 10; j++)
                {
                    p_board[i, j] = 0;
                }
            }
            return p_board;
        }
        public int[,] AgregarEmbarcacion(int[,] emb)
        {
            int [,] p_board2 = p_board;
            int i, j;
            for (i = 1; i < 10; i++)
            {
                for (j = 1; j < 10; j++)
                {
                    p_board2[i, j] += emb[i, j];
                    if ((p_board2[i, j] += emb[i, j]) == 2)
                    {
                        Console.WriteLine("Ya existe una embarcacion en esta posicion");
                        return p_board;
                    }
                }
            }
            p_board = p_board2;
            return p_board;
        }
    }
}
