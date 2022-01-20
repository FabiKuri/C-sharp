using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1  = new Player("ひろし",100);

            int hp = player1.GetHp();
            int newHp = hp - 2000;
            player1.SetHp(newHp);
            Console.WriteLine("HPは" + player1.GetHp());

            string name = player1.GetName();
            string newName = "1234567";
            player1.SetName(newName);
            Console.WriteLine("名前は" + player1.GetName());
        }
    }
}
