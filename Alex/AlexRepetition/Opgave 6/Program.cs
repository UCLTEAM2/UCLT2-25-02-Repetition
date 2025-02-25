namespace Opgave_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 5;
            int num2 = 10;

            bool isEqual = num == num2;
            bool isNotEqual = num != num2;
            bool isGreater = num > num2;
            bool isLess = num < num2;
            bool isLessOrEqual = num <= num2;
            bool isGreaterOrEqual = num > num2;

            Console.WriteLine($"Is equal: {isEqual} \nIs not equal: {isNotEqual} \nIs greater: {isGreater} \nIs less: {isLess} \nIs greater or equal: {isGreaterOrEqual} \nIs less or equal: {isLessOrEqual}");



            Console.ReadKey();
        }
    }
}
