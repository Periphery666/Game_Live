

namespace Life_Game
{

    struct Coordinate
    {
        public int _x;
        public int _y;


        #region Constr      

        public Coordinate(int y, int x)
        {
            _y = y;
            _x = x;
        }

        public Coordinate(Coordinate coo)
        {
            _x = coo._x;
            _y = coo._y;
        }

        #endregion

    }

}
