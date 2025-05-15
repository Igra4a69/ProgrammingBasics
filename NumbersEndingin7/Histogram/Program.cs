namespace Histogram;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int p1 = 0; // < 200
        int p2 = 0; // 200..399
        int p3 = 0; // 400..599
        int p4 = 0; // 600..799
        int p5 = 0; // ≥ 800

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 200)
                p1++;
            else if (num <= 399)
                p2++;
            else if (num <= 599)
                p3++;
            else if (num <= 799)
                p4++;
            else
                p5++;
        }

        Console.WriteLine($"{(p1 * 100.0 / n):F2}%");
        Console.WriteLine($"{(p2 * 100.0 / n):F2}%");
        Console.WriteLine($"{(p3 * 100.0 / n):F2}%");
        Console.WriteLine($"{(p4 * 100.0 / n):F2}%");
        Console.WriteLine($"{(p5 * 100.0 / n):F2}%");
    }
}