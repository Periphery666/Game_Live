// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{

    class Obstacles : Cell
    {
     
        public override void process()
        {
           
        }


        #region Constr

        public Obstacles(Coordinate coo) : base(coo)
        {
            Image = (char)ValueOcean.Obstacles;
        }
        public Obstacles()
        {

        }
        #endregion

    }

}
