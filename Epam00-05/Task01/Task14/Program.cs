﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N:");
            int N = 0;
            Ins(ref N);
            for (int h = 0; h < N; h++)
            {
                for (int i = 0; i < h; i++)
                {
                    for (int l = N; l > h; l--)
                        Console.Write(" ");
                    for (int j = 0; j < h - i; j++)
                        Console.Write(" ");
                    for (int k = 0; k < (2 * i + 1); k++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
        public static int Ins(ref int n)
        {
            do
            {
                var ins = Console.ReadLine();
                if (Int32.TryParse(ins, out n))
                {
                    return n;
                }
            }
            while (true);
        }
    }
}
