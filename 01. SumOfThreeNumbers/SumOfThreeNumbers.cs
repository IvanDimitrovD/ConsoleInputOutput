using System;
    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write three numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;
            Console.WriteLine(sum);
        }
    }

