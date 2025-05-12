namespace Journey;

class Program
{
    static void Main(string[] args)
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        string holidayType = "";
        double spentMoney = 0;

        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season == "summer")
            {
                holidayType = "Camp";
                spentMoney = budget * 0.30;
            }
            else if (season == "winter")
            {
                holidayType = "Hotel";
                spentMoney = budget * 0.70;
            }
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
            if (season == "summer")
            {
                holidayType = "Camp";
                spentMoney = budget * 0.40;
            }
            else if (season == "winter")
            {
                holidayType = "Hotel";
                spentMoney = budget * 0.80;
            }
        }
        else
        {
            destination = "Europe";
            holidayType = "Hotel";
            spentMoney = budget * 0.90;
        }

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{holidayType} - {spentMoney:F2}");
    }
}