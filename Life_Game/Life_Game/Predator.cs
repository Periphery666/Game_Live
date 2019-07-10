// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{
    class Predator : Prey/*, ISwim*/
    {
        public const int TIME_TO_FEED = 15;
        public int _timeToFeed { get; set; } = TIME_TO_FEED;

        public override void process(Ocean ocean)
        {
            Coordinate toCoord;

            if (--_timeToFeed >= 0)
            {
                toCoord = LogicMove.getPreyNeighborCoord(ocean, offset);
                if (toCoord._x == offset._x && toCoord._y == offset._y)
                {
                    toCoord = LogicMove.getEmptyNeighborCoord(ocean, offset);
                    _swim.moveFrom(offset, toCoord, ocean, this);
                }
                else
                {
                    _timeToFeed = TIME_TO_FEED;
                    --ocean.NumPrey;
                    ++ocean.NumKill;
                    _swim.moveFrom(offset, toCoord, ocean, this);
                }
            }

        }




        public override object Clone()
        {
            return new Predator(this);
        }





        #region Const

        public Predator(Predator pre, int timeToFeed = TIME_TO_FEED) : base(pre.offset, Prey.TIME_TO_REPRODUCE)
        {
            Image = pre.Image;
            _timeToFeed = timeToFeed;
            _swim = pre._swim;
        }

        public Predator(Coordinate coo, int timeToFeed = TIME_TO_FEED) : base(coo, Prey.TIME_TO_REPRODUCE)
        {
            Image = (char)ValueOcean.Shark;
            _timeToFeed = timeToFeed;
            _swim = new PredatorLogic();

        }

        public Predator(Coordinate coo, ISwim iPredator, int timeToFeed = TIME_TO_FEED) : this(coo, Prey.TIME_TO_REPRODUCE)
        {
            _swim = iPredator;

        }

        #endregion


    }

}
