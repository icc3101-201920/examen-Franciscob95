﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Submarino : Embarcacion, IMetodos
    {
        public int[,] posicion;
        public Submarino()
        {
            Name = "Submarino";
            LifePoints = 3;
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
