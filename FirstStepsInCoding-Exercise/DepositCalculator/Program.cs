namespace DepositCalculator;

class Program
{
    static void Main(string[] args)
    {
        double depositedAmount = double.Parse(Console.ReadLine());
        int depositPeriodMonths = int.Parse(Console.ReadLine());
        double annualInterestRate = double.Parse(Console.ReadLine());
        
        double sum = depositedAmount + depositPeriodMonths * ((depositedAmount * annualInterestRate / 100) / 12);

        Console.WriteLine($"{sum:F2}");
    }
}