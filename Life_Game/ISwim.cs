// Game_Life
//Ryazanov_Stas
//Tel phone  ---------------


namespace Life_Game
{
    interface ISwim
    {
        void moveFrom(Coordinate from, Coordinate to, Ocean ocean, Cell prey);
        Cell reproduce(Coordinate offset, Ocean ocean);

    }
}
