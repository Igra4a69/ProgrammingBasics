namespace FruitShop;

class Program
{
    static void Main(string[] args)
    {

        string fruit = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double price = 0.0;
        bool validFruit = true;
        bool validDay = true;

        if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" ||
            dayOfWeek == "Friday")
        {
            switch (fruit)
            {
                case "banana": price = 2.50; break;
                case "apple": price = 1.20; break;
                case "orange": price = 0.85; break;
                case "grapefruit": price = 1.45; break;
                case "kiwi": price = 2.70; break;
                case "pineapple": price = 5.50; break;
                case "grapes": price = 3.85; break;
                default: validFruit = false; break;
            }
        }
        else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
        {
            switch (fruit)
            {
                case "banana": price = 2.70; break;
                case "apple": price = 1.25; break;
                case "orange": price = 0.90; break;
                case "grapefruit": price = 1.60; break;
                case "kiwi": price = 3.00; break;
                case "pineapple": price = 5.60; break;
                case "grapes": price = 4.20; break;
                default: validFruit = false; break;
            }
        }
        else
        {
            validDay = false;
        }

        if (!validFruit || !validDay)
        {
            Console.WriteLine("error");
        }
        else
        {
            double totalCost = price * quantity;
            Console.WriteLine($"{totalCost:F2}");
        }
    }
}