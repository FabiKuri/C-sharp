using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int mapType = 2;

            if (mapType == 1)
            {
                hp += 10;
            }
            else if (mapType == 2)
            {
                hp -= 5;
            }
            else if (mapType == 3)
            {
                hp = 0;
            }
            else
            {
                Console.WriteLine("HPの変化なし");
            }
            Console.WriteLine("HP=" + hp);
        }
    }
}
