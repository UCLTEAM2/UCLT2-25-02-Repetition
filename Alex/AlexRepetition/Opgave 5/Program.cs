namespace Opgave_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double diameter = radius * 2;
            double areal = double.Pi * (radius * radius);
            double circumference = 2 * double.Pi * radius;
            double circumferenceDiameter = double.Pi * diameter;

            Console.WriteLine($"Radius is {radius}");
            Console.WriteLine($"Areal is {areal}, Circumference is {circumference}");
            Console.WriteLine($"Circumference based on PI and Diamter is {circumferenceDiameter}");



            Console.ReadKey();
        }
    }
}
