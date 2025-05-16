namespace Travelling;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string destination = Console.ReadLine();
            if (destination == "End")
            {
                break;
            }

            double neededBudget = double.Parse(Console.ReadLine());
            double savedMoney = 0;

            while (savedMoney < neededBudget)
            {
                double savedToday = double.Parse(Console.ReadLine());
                savedMoney += savedToday;
            }

            Console.WriteLine($"Going to {destination}!");
        }
    }
}