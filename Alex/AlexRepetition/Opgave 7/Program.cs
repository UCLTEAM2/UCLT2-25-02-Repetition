namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = -11;

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }


            Console.ReadKey();
        }
    }
}
