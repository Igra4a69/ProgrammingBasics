namespace PetShop;

class Program
{
    static void Main(string[] args)
    {
        int dogPacks = int.Parse(Console.ReadLine());
        int catPacks = int.Parse(Console.ReadLine());
        
        double dogFoodPrice = 2.50;
        double catFoodPrice = 4.00;
        
        double total = (dogPacks * dogFoodPrice) + (catPacks * catFoodPrice);
        
        Console.WriteLine($"{total} lv.");
    }
}