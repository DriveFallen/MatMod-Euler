using System;

namespace prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            void var1(double x, double y, double n, double h)
            {
                for (int i = 1; x < n; x += h, i++)
                {
                    y += h * y;
                    Console.WriteLine("x" + i + " = " + Math.Round(x, 6) + "; y = " + Math.Round(y, 6));
                }
                Console.WriteLine();
            }
            var1(0, 1, 1, 0.1);
            Console.ReadLine();
        }
    }
}