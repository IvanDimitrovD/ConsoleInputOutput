using System;
    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            // MathMax
            Console.WriteLine(Math.Max(a, b));

            // Ternery
            Console.WriteLine(a > b ? a : b);
        }
    }

