// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{
    class Prey : Cell
    {

        public static int TIME_TO_REPRODUCE = TIME_TO_REPRODUCE_CONST;
        private const int TIME_TO_REPRODUCE_CONST = 2;
        public int _timeToReproduce { get; set; }


        public override void process(Ocean ocean)
        {
            Coordinate toCoord;
            toCoord = LogicMove.getPreyNeighborCoord(ocean, offset);

            if (toCoord._x == offset._x && toCoord._y == offset._y)
            {
                --_timeToReproduce;
                toCoord = LogicMove.getEmptyNeighborCoord(ocean, offset);
                _swim.moveFrom(offset, toCoord,  ocean, this);
            }
            else
            {
                if (_timeToReproduce == 0)
                {
                    _timeToReproduce = TIME_TO_REPRODUCE;
                    Coordinate tmpMove = LogicMove.getEmptyNeighborCoord(ocean, offset);
                    ocean.assignCellAt(tmpMove, (Prey)_swim.reproduce(tmpMove, ocean));
                    ++ocean.NumPrey;
                    ++ocean.NumReproduce;

                }
                else
                {
                    toCoord = LogicMove.getEmptyNeighborCoord(ocean, offset);
                    _swim.moveFrom(offset, toCoord,  ocean, this);
                }
            }
        }


   

        public override object Clone()
        {
            return new Prey(this);
        }
      

        //public override Cell reproduce(Coordinate coo, Ocean ocean)
        //{
        //    Prey tmp = new Prey(coo, TIME_TO_REPRODUCE);
        //    ocean.NumPrey = ocean.NumPrey ;
        //    return tmp;
        //}



        #region Constr


        public Prey()
        {

        }


        public Prey(Prey prey) : base(prey.offset)
        {
            Image = prey.Image;
            _timeToReproduce = prey._timeToReproduce;
            _swim = prey._swim;
        }

        public Prey(Prey p, int timeToReproduce ) : base(p.offset)
        {
            Image = p.Image;
            _timeToReproduce = timeToReproduce;
            _swim = p._swim;

        }

        public Prey(Coordinate coo, int timeToReproduce ) : base(coo)
        {
            Image = (char)ValueOcean.Fish;
            _timeToReproduce = timeToReproduce;
            _swim = new PredatorLogic();


        }

        public Prey(Coordinate coo, ISwim iPrey , int timeToReproduce) : this(coo, timeToReproduce)
        {
            _swim = iPrey;
        }

        #endregion


    }

}
