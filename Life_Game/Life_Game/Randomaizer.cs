// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------
using System;


namespace Life_Game
{
    class Randomaizer
    {
        private static Random rand = new Random();

      
        public static int nextIntBetween(int low, int high)
        {
            return rand.Next(low, high + 1);
        }
     
    }


}
