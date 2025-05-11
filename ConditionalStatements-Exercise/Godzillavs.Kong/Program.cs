using System;

namespace Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double costumePricePerExtra = double.Parse(Console.ReadLine());
            
            double decorCost = budget * 0.10;
            
            double totalCostumePrice = extrasCount * costumePricePerExtra;
            
            if (extrasCount > 150)
            {
                totalCostumePrice *= 0.90;
            }
            
            double totalCost = decorCost + totalCostumePrice;
            
            if (totalCost > budget)
            {
                double neededMoney = totalCost - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
            else
            {
                double remainingMoney = budget - totalCost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");
            }
        }
    }
}