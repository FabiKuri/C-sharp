using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 5;
            int missilePosX = 15;

            while (playerPosX != missilePosX)
            {
                Console.WriteLine("missile at" + missilePosX);
                missilePosX--;
            }
            Console.WriteLine("HIT");
        }
    }
}
