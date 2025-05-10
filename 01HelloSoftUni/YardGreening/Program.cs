namespace YardGreening;

class Program
{
    static void Main(string[] args)
    {
        double areaInSquareMeters = double.Parse(Console.ReadLine());
        
        double pricePerSquareMeter = 7.61;
        
        double initialPrice = areaInSquareMeters * pricePerSquareMeter;
        
        double discountPercentage = 0.18; // 18%
        
        double discountAmount = initialPrice * discountPercentage;
        
        double finalPrice = initialPrice - discountAmount;
        
        Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
        Console.WriteLine($"The discount is: {discountAmount:F2} lv.");
    }
}