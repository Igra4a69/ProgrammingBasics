namespace AreaofFigures;

class Program
{
    static void Main(string[] args)
    {
        string shape = Console.ReadLine();

        double area = 0;
        
        if (shape == "square")
        {
            double side = double.Parse(Console.ReadLine());
            area = side * side;
        }
        else if (shape == "rectangle")
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            area = length * width;
        }
        else if (shape == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
        }
        else if (shape == "triangle")
        {
            double baseLength = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            area = 0.5 * baseLength * height;
        }
        Console.WriteLine($"{area:F3}");
    }
}