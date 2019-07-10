// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------


namespace Life_Game
{
    class LogicMove
    {
        public static Coordinate getEmptyCellCoord(Ocean ocean)
        {

            Coordinate empty = new Coordinate();
            do
            {
                empty._x = Randomaizer.nextIntBetween(0, Ocean.COL - 1);
                empty._y = Randomaizer.nextIntBetween(0, Ocean.ROW - 1);

            } while (ocean[empty._y, empty._x] != null);

            return empty;
        }


        private static Coordinate north(Ocean ocean, Coordinate coo, char image = ' ', bool full = true)
        {
            if (coo._y == 0)
            {
                return coo;
            }
            if (ocean[coo._y - 1, coo._x] == null && full == true)
            {
                return coo;
            }
            else
            {
                --coo._y;
                return coo;

            }
        }


        private static Coordinate south(Ocean ocean, Coordinate coo, char image = ' ', bool full = true)
        {
            int yValue;
            yValue = (coo._y + 1) % Ocean.ROW;

            if (ocean[yValue, coo._x] == null && full == true)
            {
                return coo;
            }
            else
            {
                coo._y = yValue;
                return coo;
            }
        }


        private static Coordinate east(Ocean ocean, Coordinate coo, char image = ' ', bool full = true)
        {
            int xValue;
            xValue = (coo._x + 1) % Ocean.COL;

            if (ocean[coo._y, xValue] == null && full == true)
            {
                return coo;
            }
            else
            {
                coo._x = xValue;
                return coo;
            }
        }

        private static Coordinate west(Ocean ocean, Coordinate coo, char image = ' ', bool full = true)
        {
            if (coo._x == 0)
            {
                return coo;
            }
            if (ocean[coo._y, coo._x - 1] == null && full == true)
            {
                return coo;
            }
            else
            {
                --coo._x;
                return coo;
            }
        }
  
        /// <summary>
        /// этот понос нужно починить 
        /// </summary>
        /// <param name="ocean"></param>
        /// <param name="coo"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public static Coordinate getNeighborWithImage(Ocean ocean, Coordinate coo, char image) // todo 
        {
            Coordinate[] neighbors = new Coordinate[0x04];
            int count = 0;

            Coordinate tmp = new Life_Game.Coordinate();
            bool find = true;

            if (image == (char)ValueOcean.Sea)
            {
                find = false;
            }
            tmp = north(ocean, coo, image, find);
            if (tmp._x != coo._x || tmp._y != coo._y)
            {
                neighbors[count++] = north(ocean, coo, image, find);
            }

            tmp = south(ocean, coo, image, find);
            if (tmp._x != coo._x || tmp._y != coo._y)
            {
                neighbors[count++] = south(ocean, coo, image, find);
            }

            tmp = east(ocean, coo, image, find);
            if (tmp._x != coo._x || tmp._y != coo._y)
            {
                neighbors[count++] = east(ocean, coo, image, find);
            }

            tmp = west(ocean, coo, image, find);
            if (tmp._x != coo._x || tmp._y != coo._y)
            {
                neighbors[count++] = west(ocean, coo, image, find);
            }

            if (count == 0)
            {
                return coo;
            }
            else
            {
                return neighbors[Randomaizer.nextIntBetween(0, count - 1)];
            }

        }


        public static Coordinate getEmptyNeighborCoord(Ocean ocean, Coordinate coo)
        {
            if (coo._y < Ocean.ROW && coo._x < Ocean.COL)
            {
                return getNeighborWithImage(ocean, coo, (char)ValueOcean.Sea);

            }
            return new Coordinate();
         
        }


        public static Coordinate getPreyNeighborCoord(Ocean ocean, Coordinate coo)
        {
            return getNeighborWithImage(ocean, coo, (char)ValueOcean.Fish);
        }



    }
}
