using System;
    class SumOfFiveNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] fiveNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            for (int i = 0; i < fiveNumbers.Length; i++)
            {
                sum += double.Parse(fiveNumbers[i]);
            }
            Console.WriteLine(sum);
        }
    }
