// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------
using System;


namespace Life_Game
{
    class GuardOcean
    {
        private Ocean _ocean ;

        public void Print()
        {

            Console.Clear();
            displayStats();
            displayCells();
            displayBorder();
            System.Threading.Thread.Sleep(500);
        }



        public void displayStats( )
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Iteration number {0}", _ocean.iteration++);
            Console.WriteLine("Obstacles: {0}", _ocean.NumObstacles);
            Console.WriteLine("Predators: {0}", _ocean.NumPredator);
            Console.WriteLine("Prey {0}", _ocean.NumPrey);

            displayBorder();

        }


        public void displayBorder()
        {
            for (int i = 0; i < Ocean.COL; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public void displayCells()
        {
            
            for (int j = 0; j < Ocean.ROW; j++)
            {
                for (int i = 0; i < Ocean.COL; i++)
                {
                    Console.Write(_ocean.cells[j, i].ToString());
                }
                Console.WriteLine();
            }
        }




        #region Const

        public GuardOcean()
        {

        }

        public GuardOcean(Ocean oc)
        {
            _ocean = oc;
        }

        #endregion

    }
}
