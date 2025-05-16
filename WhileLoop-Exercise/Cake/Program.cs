namespace Cake;

class Program
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int totalPieces = width * length;
        string input;
        
        while ((input = Console.ReadLine()) != "STOP")
        {
            int piecesTaken = int.Parse(input);
            totalPieces -= piecesTaken;

            if (totalPieces < 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
                return;
            }
        }

        Console.WriteLine($"{totalPieces} pieces are left.");
    }
}