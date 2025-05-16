namespace Vacation;

class Program
{
    static void Main(string[] args)
    {
        double neededMoney = double.Parse(Console.ReadLine());
        double currentMoney = double.Parse(Console.ReadLine());

        int daysCounter = 0;
        int spendCounter = 0;

        while (currentMoney < neededMoney && spendCounter < 5)
        {
            string action = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            daysCounter++;

            if (action == "spend")
            {
                spendCounter++;
                currentMoney -= amount;
                if (currentMoney < 0)
                {
                    currentMoney = 0;
                }
            }
            else if (action == "save")
            {
                spendCounter = 0;
                currentMoney += amount;
            }
        }

        if (spendCounter == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysCounter);
        }
        else
        {
            Console.WriteLine($"You saved the money for {daysCounter} days.");
        }
    }
}