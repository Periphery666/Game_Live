// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{


    class Ocean
    {
        public readonly static int COL = (int)DefaulValueOcean.Col;
        public readonly static int ROW = (int)DefaulValueOcean.ROW;
        public readonly static int NUM_ITERATIONS = (int)DefaulValueOcean.NUM_ITERATIONS;

        public int iteration { get; set; } 
        public int NumPrey { get; set; } = (int)DefaulValueOcean.NumPrey;
        public int NumPredator { get; set; } = (int)DefaulValueOcean.NumPredator;
        public int NumObstacles { get; set; } = (int)DefaulValueOcean.NumObstacles;
        public int NumKill { get; set; }
        public int NumReproduce { get; set; }

        private Cell[,] cells = new Cell[ROW, COL];

     
        public Cell this [int y, int x]
        {
            get
            {
                return cells[y, x];
            }
            set
            {
                if (value != null)
                {
                    cells[y, x] = (Cell)value.Clone();
                }
                else
                {
                    cells[y, x] = value;
                }
            }
        }


        public Cell getCellAt(Coordinate coord)
        {
            return this[coord._y, coord._x];
        }

        public void initCells(ISwim prey, ISwim pred)
        {
            addObstacles();
            addPredators(pred);
            addPrey(prey);
        }


        #region AddMarine

        public void assignCellAt(Coordinate coord, Prey cell)
        {
            cells[coord._y, coord._x] = new Prey(cell);
        }


        public void addObstacles()
        {
            Coordinate empty;
            for (int i = 0; i < NumObstacles; i++)
            {
                empty = LogicMove.getEmptyCellCoord(this);
                cells[empty._y, empty._x] = new Obstacles(empty);
            }
        }

        public void addPredators(ISwim pred)
        {
            Coordinate empty;
            for (int i = 0; i < NumPredator; i++)
            {
                empty = LogicMove.getEmptyCellCoord(this);
                cells[empty._y, empty._x] = new Predator(empty, pred);
            }
        }

        public void addPrey(ISwim prey)
        {
            Coordinate empty;
            for (int i = 0; i < NumPrey; i++)
            {
                empty = LogicMove.getEmptyCellCoord(this);
                cells[empty._y, empty._x] = new Prey(empty, prey, Prey.TIME_TO_REPRODUCE );

            }
        }


        #endregion

     
     

        public void run()
        {

            if (!(NumPredator > 0 && NumPrey > 0))
            {
                return;
            }

            for (int row = 0; row < ROW; row++)
            {
                for (int col = 0; col < COL; col++)
                {
                    if (cells[row, col] != null)
                    {
                        cells[row, col].process( this);
                    }
                  
                }
            }
        }


    }

}
