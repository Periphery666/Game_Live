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
            System.Threading.Thread.Sleep(10);
        }


        public void displayStats( )
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Iteration number {0}", _ocean.iteration++);
            Console.WriteLine("Obstacles: {0}", _ocean.NumObstacles);
            Console.WriteLine("Predators: {0}", _ocean.NumPredator);
            Console.WriteLine("Prey {0}", _ocean.NumPrey);
            Console.WriteLine("Kill {0}", _ocean.NumKill);
            Console.WriteLine("Reproduce {0}", _ocean.NumReproduce);

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
                    if (_ocean[j, i]!= null)
                    {
                        Console.Write(_ocean[j, i].ToString()); // todo 
                    }
                    else
                    {
                        Console.Write((char)ValueOcean.Sea);
                    }
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
