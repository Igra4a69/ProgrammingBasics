using System;

public class Shopping
{
    public static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        int videoCardsCount = int.Parse(Console.ReadLine());
        int processorsCount = int.Parse(Console.ReadLine());
        int ramCount = int.Parse(Console.ReadLine());
        
        double videoCardPrice = 250.0;
        
        double totalVideoCardsPrice = videoCardsCount * videoCardPrice;


        double processorPrice = totalVideoCardsPrice * 0.35;
        double ramPrice = totalVideoCardsPrice * 0.10;
        
        double totalProcessorsPrice = processorsCount * processorPrice;
        double totalRamPrice = ramCount * ramPrice;
        
        double totalPrice = totalVideoCardsPrice + totalProcessorsPrice + totalRamPrice;
        
        if (videoCardsCount > processorsCount)
        {
            totalPrice *= 0.85; 
        }
        
        if (budget >= totalPrice)
        {
            double moneyLeft = budget - totalPrice;
            Console.WriteLine($"You have {moneyLeft:F2} leva left!");
        }
        else
        {
            double moneyNeeded = totalPrice - budget;
            Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva more!");
        }
    }
}