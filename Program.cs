using System;

namespace C_sharp
{
    class Program
    {
        static float CalcAverage(int a, int b, int c)
        {
            float ave = (a + b + c) / 3.0f;
            return ave;
        }
        static void Main(string[] args)
        {
            float answer = CalcAverage(2,3,4);
            
            Console.WriteLine(answer);
        }
    }
}
