using System.Diagnostics.Metrics;

namespace Opgave_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text, to count the number of vocals: ");
            string inputString = Console.ReadLine();

            string result = NumOfVocals(inputString);

            Console.WriteLine(result);


            Console.ReadKey();
        }

        static string NumOfVocals(string inputString)
        {
            //a, e, i, o, u, y, æ, ø og å.
            int vowelCount = 0;
            int counter = 0;
            List<char> charList = new List<char>();
            charList.Add('a'); // Single quotes for char
            charList.Add('e');
            charList.Add('i');
            charList.Add('o');
            charList.Add('u');
            charList.Add('y');
            charList.Add('æ');
            charList.Add('ø');
            charList.Add('å');


            int number = inputString.Length;
            int number2 = charList.Count;


            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number2; j++)
                {
                    if (inputString[i] == charList[j])
                        vowelCount++;

                }
            }
            return vowelCount.ToString();

        }
    }
}
