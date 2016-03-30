using System;
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("{0:F2}", perimeter);
            Console.WriteLine("{0:F2}", area);
        }
    }

