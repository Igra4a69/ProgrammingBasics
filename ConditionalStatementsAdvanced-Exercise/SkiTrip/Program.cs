namespace SkiTrip;

class Program
{
    static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string rating = Console.ReadLine();
        
        int nights = days - 1; 
        
        if (nights <= 0)
        {
            Console.WriteLine("0.00");
            return;
        }
        
        double pricePerNight = 0.0;

        switch (roomType)
        {
            case "room for one person":
                pricePerNight = 18.00;
                break;
            case "apartment":
                pricePerNight = 25.00;
                break;
            case "president apartment":
                pricePerNight = 35.00;
                break;
        }
        
        double totalCost = nights * pricePerNight;
        
        double discount = 0.0; 

        if (roomType == "apartment")
        {
            if (nights < 10)
            {
                discount = 0.30; 
            }
            else if (nights >= 10 && nights <= 15)
            {
                discount = 0.35; 
            }
            else 
            {
                discount = 0.50; 
            }
        }
        else if (roomType == "president apartment")
        {
            if (nights < 10)
            {
                discount = 0.10; 
            }
            else if (nights >= 10 && nights <= 15)
            {
                discount = 0.15; 
            }
            else 
            {
                discount = 0.20; 
            }
        }
        
        totalCost = totalCost * (1 - discount); 
        
        if (rating == "positive")
        {
            totalCost = totalCost * 1.25; 
        }
        else if (rating == "negative")
        {
            totalCost = totalCost * 0.90; 
        }
        
        Console.WriteLine($"{totalCost:F2}");
    }
}