namespace Opgave_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int whileCounter = 1;

            while (whileCounter <= 10)
            {
                Console.WriteLine($"{whileCounter}");
                whileCounter++;
            }

            Console.ReadKey();
        }
    }
}
