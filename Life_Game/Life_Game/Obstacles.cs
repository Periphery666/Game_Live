// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------


namespace Life_Game
{

    sealed class Obstacles : Cell
    {

        public override void process(Ocean ocean)
        {
           
        }
       

        public override object Clone()
        {
            return new Obstacles(offset);
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
