namespace Opgave_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sum +
            //Difference - 
            //Product * 
            //Quotient /
            //Remainder %

            int num = 5;
            int sum = 10 + num;
            int difference = sum - 10;
            int product = difference * 10;
            int quotient = product / 25;
            int remainder = quotient % 2;

            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Qoutient: {quotient}, Remainder: {remainder}");



            Console.ReadKey();
        }
    }
}
