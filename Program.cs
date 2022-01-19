using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (true)
            {
                if (num >= 500)
                {
                    break;
                }

                Console.WriteLine(num);
                num = num + num;
            }
            
        }
    }
}
