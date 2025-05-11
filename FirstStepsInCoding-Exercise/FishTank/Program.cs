namespace FishTank;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        double percent = double.Parse(Console.ReadLine());
        
        double volumeCm = length * width * height;
        
        double volumeLiters = volumeCm / 1000;
        
        double neededLiters = volumeLiters * (1 - percent / 100);

        Console.WriteLine($"{neededLiters:F3}");
    }
}