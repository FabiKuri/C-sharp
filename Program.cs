using System;

namespace C_sharp
{
    class Program
    {
        static void Shop(string itemName)
        {
            Console.WriteLine("いらっしゃいませ");

            if (itemName == "薬草")
            {
                Console.WriteLine(itemName + "は100円です");
            }
            else if (itemName == "棍棒")
            {
                Console.WriteLine(itemName + "は1500円です");
            }
            else 
            {
                Console.WriteLine("売り切れです");
            }
        }
        static void Main(string[] args)
        {
            Shop("薬草");
        }
    }
}
