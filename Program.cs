﻿using System;

namespace C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数をまとめて初期化できる
            float[] weights = {41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f, 41.5f, 41.4f, 41.9f};

            //
            foreach (float w in weights)
            {
                Console.WriteLine(w);
            }
            
        }
    }
}
