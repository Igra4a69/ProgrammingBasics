namespace NewHouse;

class Program
{
    static void Main(string[] args)
    {
        string flowerType = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        int budget = int.Parse(Console.ReadLine());

        double pricePerFlower = 0;
        
        switch (flowerType)
        {
            case "Roses":
                pricePerFlower = 5;
                break;
            case "Dahlias":
                pricePerFlower = 3.80;
                break;
            case "Tulips":
                pricePerFlower = 2.80;
                break;
            case "Narcissus":
                pricePerFlower = 3;
                break;
            case "Gladiolus":
                pricePerFlower = 2.50;
                break;
        }

        double totalPrice = pricePerFlower * count;
        
        if (flowerType == "Roses" && count > 80)
        {
            totalPrice *= 0.90;
        }
        else if (flowerType == "Dahlias" && count > 90)
        {
            totalPrice *= 0.85; 
        }
        else if (flowerType == "Tulips" && count > 80)
        {
            totalPrice *= 0.85; 
        }
        else if (flowerType == "Narcissus" && count < 120)
        {
            totalPrice *= 1.15; 
        }
        else if (flowerType == "Gladiolus" && count < 80)
        {
            totalPrice *= 1.20;
        }
        
        if (budget >= totalPrice)
        {
            double moneyLeft = budget - totalPrice;
            Console.WriteLine($"Hey, you have a great garden with {count} {flowerType} and {moneyLeft:F2} leva left.");
        }
        else
        {
            double neededMoney = totalPrice - budget;
            Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
        }
    }
}