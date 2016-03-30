using System;
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            double xOne;
            double xTwo;

            if (a != 0)
            {
                if (discriminant < 0)
                {
                    Console.WriteLine("No real roots");
                }
                else if (discriminant == 0)
                {
                    xOne = xTwo = (-b / (2 * a));
                    Console.WriteLine("x1 == x2 = {0}", xOne);
                }
                else
                {
                    xOne = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    xTwo = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("roots: ");
                    Console.WriteLine("x1 = {0}; x2 = {1}", xOne, xTwo);
                }
            }
            else
            {
                xOne = xTwo = (-c / b);
                Console.WriteLine("x1 == x2 = {0}", xOne);
            }
        }
    }
