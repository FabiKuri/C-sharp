using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数をまとめて初期化できる
            float[] weights = {41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f, 41.5f, 41.4f, 41.9f};

            float sum = 0.0f;
            
            for (int i = 0;i < weights.Length; i++)
            {
                sum += weights[i];
            }
            
            float average = sum / weights.Length;
            Console.WriteLine("平均値は" + average + "です");
        }
    }
}
