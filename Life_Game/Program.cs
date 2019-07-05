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
            
            ocean.initialize();

            GuardOcean guardOc = new GuardOcean(ocean);

            for (int i = 0; i < Ocean.NUM_ITERATIONS; i++)
            {
                ocean.run();
                guardOc.Print();

            }


        }
    }
}
