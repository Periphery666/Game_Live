// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------

namespace Life_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Ocean ocean = new Ocean();

            ISwim swimPrey = new PreyLogic();
            ISwim swimPred = new PredatorLogic();

            ocean.initCells(swimPrey, swimPred);

            GuardOcean guardOc = new GuardOcean(ocean);

            for (int i = 0; i < Ocean.NUM_ITERATIONS; i++)
            {
                guardOc.Print();
                ocean.run();

            }

        }
    }
}
