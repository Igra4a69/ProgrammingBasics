﻿namespace TradeCommissions;

class Program
{
    static void Main(string[] args)
    {
        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        double commission = -1.0;

        if (sales >= 0)
        {
            if (city == "Sofia")
            {
                if (sales <= 500)
                    commission = sales * 0.05;
                else if (sales <= 1000)
                    commission = sales * 0.07;
                else if (sales <= 10000)
                    commission = sales * 0.08;
                else
                    commission = sales * 0.12;
            }
            else if (city == "Varna")
            {
                if (sales <= 500)
                    commission = sales * 0.045;
                else if (sales <= 1000)
                    commission = sales * 0.075;
                else if (sales <= 10000)
                    commission = sales * 0.10;
                else
                    commission = sales * 0.13;
            }
            else if (city == "Plovdiv")
            {
                if (sales <= 500)
                    commission = sales * 0.055;
                else if (sales <= 1000)
                    commission = sales * 0.08;
                else if (sales <= 10000)
                    commission = sales * 0.12;
                else
                    commission = sales * 0.145;
            }
        }

        if (commission >= 0)
            Console.WriteLine($"{commission:F2}");
        else
            Console.WriteLine("error");
    }
}