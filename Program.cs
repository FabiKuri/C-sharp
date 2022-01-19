using System;

namespace C_sharp
{
    class Program
    {
        // static void Shop(string itemName)
        // {
        //     Console.WriteLine("いらっしゃいませ");

        //     if (itemName == "薬草")
        //     {
        //         Console.WriteLine(itemName + "は100円です");
        //     }
        //     else if (itemName == "棍棒")
        //     {
        //         Console.WriteLine(itemName + "は1500円です");
        //     }
        //     else 
        //     {
        //         Console.WriteLine("売り切れです");
        //     }
        // }

        static void ShowEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("偶数です");
            }
            else
            {
                Console.WriteLine("奇数です");
            }
        }
        static void Main(string[] args)
        {

            ShowEvenOrOdd(4);
            // Shop("薬草");
        }
    }
}
