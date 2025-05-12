namespace HotelRoom;

class Program
{
    static void Main(string[] args)
    {
        string month = Console.ReadLine();
        int nights = int.Parse(Console.ReadLine());

        double studioPricePerNight = 0;
        double apartmentPricePerNight = 0;
        
        switch (month)
        {
            case "May":
            case "October":
                studioPricePerNight = 50;
                apartmentPricePerNight = 65;
                break;
            case "June":
            case "September":
                studioPricePerNight = 75.20;
                apartmentPricePerNight = 68.70;
                break;
            case "July":
            case "August":
                studioPricePerNight = 76;
                apartmentPricePerNight = 77;
                break;
        }
        
        double studioTotal = studioPricePerNight * nights;
        double apartmentTotal = apartmentPricePerNight * nights;
        
        if ((month == "May" || month == "October"))
        {
            if (nights > 14)
            {
                studioTotal *= 0.70; 
            }
            else if (nights > 7)
            {
                studioTotal *= 0.95; 
            }
        }
        else if ((month == "June" || month == "September") && nights > 14)
        {
            studioTotal *= 0.80; 
        }
        
        if (nights > 14)
        {
            apartmentTotal *= 0.90;
        }
        
        Console.WriteLine($"Apartment: {apartmentTotal:F2} lv.");
        Console.WriteLine($"Studio: {studioTotal:F2} lv.");
    }
}