using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_Game
{


    class Coordinate
    {
        public int _x;
        public int _y;

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;

        }

        public Coordinate(Coordinate coo)
        {
            _x = coo._x;
            _y = coo._y;
        }

        public Coordinate()
        {

        }
    }

}
