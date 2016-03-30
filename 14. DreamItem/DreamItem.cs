using System;
    class DreamItem
    {
        static void Main()
        {
        string format = Console.ReadLine();
        string[] input = format.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal itemPrice = decimal.Parse(input[3]);
        int days = 0;
        switch (input[0])
        {
            case "Feb": days = 28; break;
            case "Apr": days = 30; break;
            case "June": days = 30; break;
            case "Sept": days = 30; break;
            case "Nov": days = 30; break;
            default: days = 31;
                break;
        }
        days = days - 10;
        decimal moneyEarn = days * moneyPerHour * hoursPerDay;
        if (moneyEarn > 700)
        {
            moneyEarn += moneyEarn * 0.1M;
        }
        if (moneyEarn >= itemPrice)
        {
            Console.WriteLine("Money left = {0:F2} leva.", moneyEarn - itemPrice);
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - moneyEarn);
        }
    }
    }
