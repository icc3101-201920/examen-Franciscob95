using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Player
    {
        private int id;
        private bool active;
        private List<Embarcacion> embarcaciones;
        public Player(int id, bool active, List<Embarcacion> embarcaciones)
        {
            this.id = id;
            this.active = active;
            this.embarcaciones = embarcaciones;
        }
    }
}
