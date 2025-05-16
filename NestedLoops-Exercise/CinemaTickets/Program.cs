namespace CinemaTickets;

class Program
{
    static void Main(string[] args)
    {
        int totalTickets = 0;
        int studentTickets = 0;
        int standardTickets = 0;
        int kidTickets = 0;

        string movieName;
        while ((movieName = Console.ReadLine()) != "Finish")
        {
            int freeSeats = int.Parse(Console.ReadLine());
            int ticketsSoldForMovie = 0;

            for (int i = 0; i < freeSeats; i++)
            {
                string ticketType = Console.ReadLine();
                if (ticketType == "End")
                {
                    break;
                }

                switch (ticketType)
                {
                    case "student":
                        studentTickets++;
                        break;
                    case "standard":
                        standardTickets++;
                        break;
                    case "kid":
                        kidTickets++;
                        break;
                }

                ticketsSoldForMovie++;
                totalTickets++;
            }

            double percentFull = (double)ticketsSoldForMovie / freeSeats * 100;
            Console.WriteLine($"{movieName} - {percentFull:F2}% full.");
        }

        Console.WriteLine($"Total tickets: {totalTickets}");
        Console.WriteLine($"{(double)studentTickets / totalTickets * 100:F2}% student tickets.");
        Console.WriteLine($"{(double)standardTickets / totalTickets * 100:F2}% standard tickets.");
        Console.WriteLine($"{(double)kidTickets / totalTickets * 100:F2}% kids tickets.");
    }
}
