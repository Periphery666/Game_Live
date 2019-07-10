// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------


namespace Life_Game
{
    abstract class Cell 
    {
        public Coordinate offset { get; set; }
        public char Image { get; set; }

        protected ISwim _swim;

        public Coordinate getOffset() // убрать это брань
        {
            return offset;
        }

        public abstract object Clone();

        public abstract void process( Ocean ocean);
   
        public override string ToString()
        {
            return Image.ToString();
        }



        #region Constr

        public Cell(Cell cell)
        {

            offset = new Coordinate(cell.offset);
            Image = cell.Image;

        }

        public Cell(Coordinate coo)
        {
            offset = new Coordinate(coo);
        }

        public Cell()
        {

        }


        #endregion

    }

}
