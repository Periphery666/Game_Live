// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{


    class Ocean
    {
        public static int COL = 70;
        public static int ROW = 25;
        public static int NUM_ITERATIONS = 1000;

        public int iteration { get; set; } = 0;
        public int Size { get; set; }
        public int NumPrey { get; set; } = 150;
        public int NumPredator { get; set; } = 20;
        public static Randomaizer rand { get; set; } = new Randomaizer();
        public int NumObstacles { get; set; } = 20;

        public Cell[,] cells = new Cell[ROW, COL];


        /// <summary>
        /// инициализация счетчика случайных чисел и размер океана
        /// </summary>
        public void initialize()
        {
            rand.initialize();
            Size = COL * ROW;
            initCells();
        }


        /// <summary>
        /// ввод пользователем данных для инициализации
        /// </summary>
        public void initCells()
        {
            addEmptyCells();
            addObstacles();
            addPredators();
            addPrey();

            //displayStats(ref iteration);
            //displayCells();
            //displayBorder();
            Cell.ocean1 = this;
        }

        public void addEmptyCells()
        {
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    cells[i, j] = new Cell(new Coordinate(j, i));
                }
            }
        }

        public void addObstacles()
        {
            Coordinate empty = new Coordinate();
            for (int i = 0; i < NumObstacles; i++)
            {
                empty = getEmptyCellCoord();
                cells[empty._y, empty._x] = new Obstacles(empty);
            }
        }

        public void addPredators()
        {
            Coordinate empty = new Coordinate();
            for (int i = 0; i < NumPredator; i++)
            {
                empty = getEmptyCellCoord();
                cells[empty._y, empty._x] = new Predator(empty);

            }
        }

        public void addPrey()
        {
            Coordinate empty = new Coordinate();
            for (int i = 0; i < NumPrey; i++)
            {
                empty = getEmptyCellCoord();
                cells[empty._y, empty._x] = new Prey(empty);

            }
        }

        public Coordinate getEmptyCellCoord()
        {
            int x;
            int y;
            Coordinate empty;

            do
            {
                x = rand.nextIntBetween(0, COL - 1);
                y = rand.nextIntBetween(0, ROW - 1);

            } while (cells[y, x].Image != (char)ValueOcean.Sea);
            empty = cells[y, x].getOffset();
            return new Coordinate(empty);

        }


   



        public void run()
        {



            if (NumPredator > 0 && NumPrey > 0)
            {
                for (int row = 0; row < ROW; row++)
                {
                    for (int col = 0; col < COL; col++)
                    {
                        cells[row, col].process();
                    }
                }

            }

        }





    }



}
