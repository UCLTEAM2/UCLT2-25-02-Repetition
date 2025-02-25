namespace Opgave_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 2 numbers to add\n");
            Console.Write("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int result = Add(x, y);

            Console.WriteLine($"\nThe result is {result}");



            Console.ReadKey();
        }

        static int Add(int x, int y)
        {

            int sum = x + y;

            return sum;

        }
    }
}
