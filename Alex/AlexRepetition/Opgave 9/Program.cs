namespace Opgave_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = Convert.ToInt32(Console.ReadLine());

            int days = input % 2;
           
            if (days == 0)
            {
                Console.WriteLine("Its leap year!");
            }
            else
            {
                Console.WriteLine("Its not leapyear!");
            }

          


            Console.ReadKey();
        }
    }
}
