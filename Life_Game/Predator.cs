// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{
    class Predator : Prey
    {
        private const int TIME_TO_FEED = 15;
        private int _timeToFeed = TIME_TO_FEED;


        public override void process()
        {
            Coordinate toCoord;

            if (--_timeToFeed <= 0)
            {
                ocean1.cells[offset._y, offset._x] = new Cell(offset);
                ocean1.NumPredator = ocean1.NumPredator - 1;
            }
            else
            {
                toCoord = getPreyNeighborCoord();
                if (toCoord != offset)
                {
                    ocean1.NumPrey = ocean1.NumPrey - 1;
                    _timeToFeed = TIME_TO_FEED;
                    moveFromPredator( offset,  toCoord);
                }
                else
                {
                    toCoord = getEmptyNeighborCoord();
                    moveFromPredator( offset,  toCoord);
                }
            }
        }


        public void moveFromPredator(Coordinate from, Coordinate to)
        {

            Cell tmp = getCellAt(from);

            if (tmp.Image == (char)ValueOcean.Fish)
            {
                ocean1.cells[to._y, to._x] = new Predator(to, _timeToFeed);
                ocean1.cells[from._y, from._x] = new Cell(from);

                _timeToFeed = TIME_TO_FEED;
            }
            else
            {
                ocean1.cells[to._y, to._x] = new Predator(to, _timeToFeed);
                ocean1.cells[from._y, from._x] = new Cell(from);
            }

        }

        public override Cell reproduce(Coordinate offset)
        {
            Predator tmp = new Predator(offset);
            ocean1.NumPredator = ocean1.NumPredator;

            return tmp;
        }


        #region Const

        public Predator()
        {

        }

        public Predator(Predator pre, int timeToFeed = TIME_TO_FEED) :base(pre.offset)
        {
            Image = pre.Image;
            _timeToFeed = timeToFeed;
        }

        public Predator(Coordinate coo, int timeToFeed = TIME_TO_FEED) : base(coo)
        {
            Image = (char)ValueOcean.Shark;
            _timeToFeed = timeToFeed;
        }
        #endregion


    }

}
