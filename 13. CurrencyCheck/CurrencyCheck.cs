using System;
    class CurrencyCheck
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());

            double payInRubles = (r / 100) * 3.5;
            double payInDollars = d * 1.5;
            double payInEuro = e * 1.95;
            double payInB = b / 2;
            double payInM = m;

            double cheapest = double.MaxValue;
            cheapest = Math.Min(payInRubles, cheapest);
            cheapest = Math.Min(payInDollars, cheapest);
            cheapest = Math.Min(payInEuro, cheapest);
            cheapest = Math.Min(payInB, cheapest);
            cheapest = Math.Min(payInM, cheapest);
    
            Console.WriteLine("{0:F2}", cheapest);
        }
    }
