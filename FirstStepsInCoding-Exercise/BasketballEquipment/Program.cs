namespace BasketballEquipment;

class Program
{
    static void Main(string[] args)
    {
        int annualFee = int.Parse(Console.ReadLine());
        
        double sneakersPrice = annualFee * 0.60; // 40% по-малка
        double outfitPrice = sneakersPrice * 0.80; // 20% по-евтина от кецовете
        double ballPrice = outfitPrice / 4;
        double accessoriesPrice = ballPrice / 5;
        
        double totalPrice = annualFee + sneakersPrice + outfitPrice + ballPrice + accessoriesPrice;
        
        Console.WriteLine($"{totalPrice:F2}");
    }
}