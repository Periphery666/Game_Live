// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{
    class Prey : Cell
    {

        private const int TIME_TO_REPRODUCE = 6;
        private int _timeToReproduce;


        public void moveFromPrey(Coordinate from, Coordinate to)
        {

            Cell tmp = getCellAt(from);

            if (tmp.Image == (char)ValueOcean.Fish)
            {
                ocean1.cells[to._y, to._x] = new Prey(to, _timeToReproduce);
                ocean1.cells[from._y, from._x] = new Cell(from);

            }
        }


        public override void process()
        {
            Coordinate toCoord;
            toCoord = getPreyNeighborCoord();

            if (toCoord._x == offset._x && toCoord._y == offset._y)
            {
                toCoord = getEmptyNeighborCoord();
            }

            if (--_timeToReproduce >= 0)
            {
                moveFromPrey(offset, toCoord);
            }
            else
            {
                _timeToReproduce = TIME_TO_REPRODUCE;
                Coordinate tmpMove = getEmptyNeighborCoord();
                assignCellAt(tmpMove, (Prey)reproduce(tmpMove));
                ocean1.NumPrey++;
            }
        }


        public override Cell reproduce(Coordinate coo)
        {
            Prey tmp = new Prey(coo);
            ocean1.NumPrey = ocean1.NumPrey + 1;
            return tmp;
        }



        #region Constr


        public Prey()
        {

        }

        public Prey(Prey p, int timeToReproduce = 6) : base(p.offset)
        {
            Image = p.Image;
            _timeToReproduce = timeToReproduce;
        }

        public Prey(Coordinate coo, int timeToReproduce = 6) : base(coo)
        {
            Image = (char)ValueOcean.Fish;
            _timeToReproduce = timeToReproduce;

        }

        #endregion




    }

}
