using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Game
{
    class PreyLogic : ISwim
    {
        public void moveFrom(Coordinate from, Coordinate to, Ocean ocean, Cell cell)
        {
            Prey prey = cell as Prey;

            if (prey == null )
            {
                return;
            }

            Cell tmp = ocean.getCellAt(from);

            if (tmp.Image == (char)ValueOcean.Fish)
            {
                ocean[to._y, to._x] = new Prey(to, prey._timeToReproduce);
                ocean[from._y, from._x] = null;
            }
        }


        public Cell reproduce(Coordinate coo, Ocean ocean)
        {
            Prey tmp = new Prey(coo, Prey.TIME_TO_REPRODUCE);
            ocean.NumPrey = ocean.NumPrey;
            return tmp;
        }



    }
}
