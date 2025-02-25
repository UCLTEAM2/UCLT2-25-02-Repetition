namespace Opgave_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int sum = 0;
            int count = 1;
            do
            {
                sum += number;
                number++;

                Console.WriteLine(sum);
                
                count++;

                
            }
            while (count <= 10);

            Console.ReadKey();
        }
    }
}
