using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10000;
            int x = 2;
            int num = 0;

            while (n > 100)
            {
                n = n / x;
                num++;
            }
            Console.WriteLine(num);
        }
    }
}
