namespace Moving;

class Program
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int freeVolume = width * length * height;
        string input;

        while ((input = Console.ReadLine()) != "Done")
        {
            int boxes = int.Parse(input);
            freeVolume -= boxes;

            if (freeVolume < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeVolume)} Cubic meters more.");
                return;
            }
        }

        Console.WriteLine($"{freeVolume} Cubic meters left.");
    }
}