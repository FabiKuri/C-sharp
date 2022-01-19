using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] weights = new float[7];

            weights[0] = 41.2f;
            weights[1] = 42.5f;
            weights[2] = 44.9f;
            weights[3] = 43.2f;
            weights[4] = 45.1f;
            weights[5] = 43.2f;
            weights[6] = 43.7f;

            for (int i = 0;i < 7; i++)
            {
                Console.WriteLine(weights[i]);
            }
            
        }
    }
}
