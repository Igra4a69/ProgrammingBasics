namespace FoodDelivery;

class Program
{
    static void Main(string[] args)
    {
        int chickenMenus = int.Parse(Console.ReadLine());
        int fishMenus = int.Parse(Console.ReadLine());
        int vegMenus = int.Parse(Console.ReadLine());
        
        double chickenPrice = chickenMenus * 10.35;
        double fishPrice = fishMenus * 12.40;
        double vegPrice = vegMenus * 8.15;
        
        double totalMenuPrice = chickenPrice + fishPrice + vegPrice;
        
        double dessertPrice = totalMenuPrice * 0.20;
        
        double deliveryPrice = 2.50;
        
        double totalPrice = totalMenuPrice + dessertPrice + deliveryPrice;
        
        Console.WriteLine($"{totalPrice:F2}");
    }
}