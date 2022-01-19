using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosY = 3;

            if (playerPosY >= 0)
            {
                Console.WriteLine("走る!");
            }
            else
            {
                Console.WriteLine("泳ぐ!");
            }
        }
    }
}
