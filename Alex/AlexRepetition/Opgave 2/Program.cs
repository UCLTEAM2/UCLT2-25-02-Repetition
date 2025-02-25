namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 25;
            double fahrenheit = 77;

            double CtoF = celsius * (9.0 / 5.0) + 32;
            double FtoC = (fahrenheit - 32) * (5.0 / 9.0);

            Console.WriteLine($"{celsius}C is equal to {CtoF}F");
            Console.WriteLine($"{fahrenheit}F is equal to {FtoC}C");
            


            Console.ReadKey();
        }
    }
}
