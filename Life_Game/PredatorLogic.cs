using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Game
{
    class PredatorLogic : ISwim
    {

        public  void moveFrom(Coordinate from, Coordinate to, Ocean ocean, Cell cell)
        {
            Predator pred = cell as Predator;
            if (pred == null)
            {
                return;
            }

            Cell tmp = ocean.getCellAt(from);
            if (tmp.Image == (char)ValueOcean.Fish)
            {
                ocean[to._y, to._x] = new Predator(to, pred._timeToFeed);
                ocean[from._y, from._x] = null;

                pred._timeToFeed = Predator.TIME_TO_FEED; //todo what is this MTF
            }
            else
            {
                ocean[to._y, to._x] = new Predator(to, pred._timeToFeed);
                ocean[from._y, from._x] = null;
            }
        }



        public  Cell reproduce(Coordinate offset, Ocean ocean)
        {
            Predator tmp = new Predator(offset);
            ocean.NumPredator = ocean.NumPredator;
            return tmp;
        }
    }
}
