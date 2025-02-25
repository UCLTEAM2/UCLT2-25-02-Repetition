namespace Opgave_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a factorial number: ");
            int fakultet = Convert.ToInt32(Console.ReadLine());
            

            int result = MathThing(fakultet);
            Console.WriteLine($"The Factorial is: {result}");

        }

        static int MathThing(int fakultet)
        {
            int product = 1;
            while (fakultet > 1)
            {
                product *= fakultet;
                fakultet--;
                
            }

            return product;
        }

       
    }
}
