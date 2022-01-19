using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1  = new Player();
            player1.name = "たかし";
            player1.hp = 100;

            Player player2 = new Player();
            player2.name =  "ひろし";
            player2.hp = 50;

            player1.Attack();
            player2.Attack();
        }
    }
}
