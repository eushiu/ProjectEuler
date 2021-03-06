﻿using System;

namespace EulerDay2
{
    class Program
    {
        //Each new term in the Fibonacci sequence is generated by adding the previous two terms.By starting with 1 and 2, the first 10 terms will be:
        //1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        //By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms
        public static int Fib(int x)
        {
            return x <= 0 ? 1 : Fib(x - 2) + Fib(x - 1);
        }
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int x = 0; Fib(x) < 4000000; x++)
            {
                if (Fib(x) % 2 == 0)
                {
                    sum = sum + Fib(x);
                }
            }

            Console.WriteLine("sum={0}", sum);
            Console.ReadKey();
        }
    }
}