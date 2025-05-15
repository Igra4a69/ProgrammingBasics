namespace SumNumbers;

class Program
{
    static void Main(string[] args)
    {
        int targetSum = int.Parse(Console.ReadLine());
        int currentSum = 0;

        while (currentSum < targetSum)
        {
            int number = int.Parse(Console.ReadLine());
            currentSum += number;
        }

        Console.WriteLine(currentSum);
    }
}