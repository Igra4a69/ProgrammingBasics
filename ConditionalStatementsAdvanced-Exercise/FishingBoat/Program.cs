namespace FishingBoat;

class Program
{
    static void Main(string[] args)
    {
        int budget = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int fishermen = int.Parse(Console.ReadLine());

        double shipPrice = 0;

        switch (season)
        {
            case "Spring":
                shipPrice = 3000;
                break;
            case "Summer":
            case "Autumn":
                shipPrice = 4200;
                break;
            case "Winter":
                shipPrice = 2600;
                break;
        }

        if (fishermen <= 6)
        {
            shipPrice *= 0.90;
        }
        else if (fishermen >= 7 && fishermen <= 11)
        {
            shipPrice *= 0.85;
        }
        else if (fishermen >= 12)
        {
            shipPrice *= 0.75;
        }

        if (fishermen % 2 == 0 && season != "Autumn")
        {
            shipPrice *= 0.95;
        }

        if (budget >= shipPrice)
        {
            double moneyLeft = budget - shipPrice;
            Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
        }
        else
        {
            double neededMoney = shipPrice - budget;
            Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
        }
    }
}