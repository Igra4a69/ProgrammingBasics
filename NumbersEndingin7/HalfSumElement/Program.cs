namespace HalfSumElement;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int totalSum = 0;
        int maxNumber = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            totalSum += number;

            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        int sumOthers = totalSum - maxNumber;

        if (maxNumber == sumOthers)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {maxNumber}");
        }
        else
        {
            int diff = Math.Abs(maxNumber - sumOthers);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }
    }
}