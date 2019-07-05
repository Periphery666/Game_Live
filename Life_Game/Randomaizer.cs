// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------
using System;


namespace Life_Game
{
    class Randomaizer
    {
        private static Random rand = new Random();

        private int seed1;
        private int seed2;
        private static int first = 1;
        private const int MAX = 32767;


        public void initialize()
        {
            seed1 = 3797;
            seed2 = 2117;

        }

        public void Init(int s1, int s2)
        {
            seed1 = s1;
            seed2 = s2;
        }


        public float randReal()
        {
            int c;

            if (first != 0) // todo
            {
                seed1 *= 2;
                seed2 *= 2;

                if (seed1 > MAX)
                {
                    seed1 = MAX;
                }
                if (seed2 > MAX)
                {
                    seed2 = MAX;
                }

                first = 0;

                for (int index = 0; index < 30; index++)
                {
                    randReal();
                }
            }

            c = seed1 + seed2;

            if (c > MAX)
            {
                c = MAX;
            }
            c *= 2;

            if (c > MAX)
            {
                c = MAX;
            }
            seed1 = seed2;
            seed2 = c;

            return c / 32767f;


        }


        public int nextIntBetween(int low, int high)
        {
            return rand.Next(low, high);
        }

     
    }


}
