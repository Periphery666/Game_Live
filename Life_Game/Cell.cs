// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------


namespace Life_Game
{
    class Cell
    {
        public static Ocean ocean1;
        public Coordinate offset { get; set; } = new Coordinate();
        public char Image { get; set; }


        public virtual void process()
        {
            //  БАЛАЛАЙКА
            // Так надо 
        }

        public override string ToString()
        {
            return Image.ToString();
        }
       
        public virtual Cell reproduce(Coordinate coo)
        {
            Cell tmp = new Cell(coo);
            return tmp;
        }


        //Методы поиска соседей
        public Cell getCellAt(Coordinate coord)
        {
            return  ocean1.cells[coord._y, coord._x];
        }

        public void assignCellAt(Coordinate coord, Prey cell)
        {
            ocean1.cells[coord._y, coord._x] = new Prey( cell);
        }
    


        public Cell getNeighborWithImage(char image)
        {
            Cell[] neighbors = new Cell[4];
            int count = 0;


            if (north().Image == image)
            {
                neighbors[count++] = north();
            }

            if (south().Image == image)
            {
                neighbors[count++] = south();
            }

            if (east().Image == image)
            {
                neighbors[count++] = east();
            }

            if (west().Image == image)
            {
                neighbors[count++] = west();
            }

            if (count == 0)
            {
                return this;
            }
            else
            {
                return neighbors[ Ocean.rand.nextIntBetween(0, count - 1)];
            }

        }


        public Coordinate getEmptyNeighborCoord()
        {
            return getNeighborWithImage((char)ValueOcean.Sea).getOffset();
        }

        public Coordinate getPreyNeighborCoord()
        {
            return getNeighborWithImage((char)ValueOcean.Fish).getOffset();
        }


        public Cell north()
        {
   
            if (offset._y > 0)
            {
                return ocean1.cells[offset._y - 1, offset._x];
            }
            return ocean1.cells[Ocean.ROW - 1, offset._x];

        }


        public Cell south()
        {
            int yValue;
            yValue = (offset._y + 1) % Ocean.ROW;

            return ocean1.cells[yValue, offset._x];
        }


        public Cell east()
        {
            int xValue;
            xValue = (offset._x + 1) % Ocean.COL;

            return ocean1.cells[offset._y, xValue];
        }


        public Cell west()
        {
           

            if (offset._x > 0)
            {
            return ocean1.cells[offset._y, offset._x - 1];

            }
            return ocean1.cells[offset._y, Ocean.COL - 1];
        }


        //методы обработки и отоброжения

        public Coordinate getOffset()
        {
            return offset;
        }


        #region Constr

        public Cell(Cell cell)
        {

            offset = new Coordinate(cell.offset);
            Image = cell.Image;

        }

        public Cell(Coordinate coo)
        {
            offset._x = coo._x;
            offset._y = coo._y;
            Image = (char)ValueOcean.Sea;
        }

        public Cell()
        {

        }


        #endregion

    }

}
