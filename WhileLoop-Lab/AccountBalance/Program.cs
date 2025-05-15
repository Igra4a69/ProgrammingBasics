namespace AccountBalance;

class Program
{
    static void Main(string[] args)
    {
        double total = 0;
        string input;

        while ((input = Console.ReadLine()) != "NoMoreMoney")
        {
            double amount = double.Parse(input);

            if (amount < 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }

            total += amount;
            Console.WriteLine($"Increase: {amount:F2}");
        }

        Console.WriteLine($"Total: {total:F2}");
    }
}