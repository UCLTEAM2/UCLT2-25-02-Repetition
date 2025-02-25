namespace Opgave_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text to reverse: ");
            string inputString = Console.ReadLine();

            string result = StringReverse(inputString);

            Console.WriteLine(result);

        }


        static string StringReverse(string inputString)
        {
            string reverseString = "";
            int lenght;

            lenght = inputString.Length - 1;

            while (lenght >= 0)
            {
                reverseString = reverseString + inputString[lenght];
                lenght--;
            }
            return reverseString;

        }
    }
}
