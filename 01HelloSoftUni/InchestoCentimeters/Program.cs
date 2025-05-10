namespace InchestoCentimeters;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Въведете инчове: ");
        double inches = double.Parse(Console.ReadLine());
        
        double centimeters = inches * 2.54;
        
        Console.WriteLine($"{centimeters:F2} см");
    }
}