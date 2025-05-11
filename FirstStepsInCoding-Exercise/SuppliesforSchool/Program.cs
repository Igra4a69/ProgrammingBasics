namespace SuppliesforSchool;

class Program
{
    static void Main(string[] args)
    {
        int pensCount = int.Parse(Console.ReadLine());
        int markersCount = int.Parse(Console.ReadLine());
        int boardCleanerLiters = int.Parse(Console.ReadLine());
        int discountPercent = int.Parse(Console.ReadLine());
        
        double pensPrice = pensCount * 5.80;
        double markersPrice = markersCount * 7.20;
        double cleanerPrice = boardCleanerLiters * 1.20;
        
        double totalPrice = pensPrice + markersPrice + cleanerPrice;
        
        double discount = totalPrice * discountPercent / 100;
        
        double finalPrice = totalPrice - discount;
        
        Console.WriteLine($"{finalPrice:F2}");
    }
}