using System;
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
