using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1  = new Player("ひろし",100);

            Console.WriteLine(player1.name + "の体力は" + player1.hp);
        }
    }
}
