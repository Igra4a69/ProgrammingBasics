namespace Combinations;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int x1 = 0; x1 <= n; x1++)
        {
            for (int x2 = 0; x2 <= n; x2++)
            {
                int x3 = n - x1 - x2;
                if (x3 >= 0)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}