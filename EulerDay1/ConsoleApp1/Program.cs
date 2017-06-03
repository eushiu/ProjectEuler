using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int x = 1; x < 1000; x++)
            {
                if(x % 3 == 0 || x % 5 == 0)
                {
                    sum = sum + x;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}