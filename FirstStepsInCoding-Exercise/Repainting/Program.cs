namespace Repainting;

class Program
{
    static void Main(string[] args)
    {
        int nylonQuantity = int.Parse(Console.ReadLine());
        int paintQuantity = int.Parse(Console.ReadLine());
        int thinnerQuantity = int.Parse(Console.ReadLine());
        int hoursWork = int.Parse(Console.ReadLine());
        
        double nylonPrice = (nylonQuantity + 2) * 1.50;
        double paintPrice = (paintQuantity * 1.10) * 14.50;
        double thinnerPrice = thinnerQuantity * 5.00;
        double bagsPrice = 0.40;
        
        double totalMaterialsPrice = nylonPrice + paintPrice + thinnerPrice + bagsPrice;
        
        double workPrice = totalMaterialsPrice * 0.30 * hoursWork;
        
        double totalPrice = totalMaterialsPrice + workPrice;
        
        Console.WriteLine(totalPrice);
    }
}