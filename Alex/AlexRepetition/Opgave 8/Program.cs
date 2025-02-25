namespace Opgave_8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter your grade: ");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());


            checkGrade(grade);


            Console.ReadKey();
        }

        static void checkGrade(char grade)
        {
            if (grade == 'A' || grade == 'B' || grade == 'C' || grade == 'D')
            {
                Console.WriteLine($"You've passed with the grade {grade}");
            }
            else
            {
                Console.WriteLine($"You failed with the grade {grade}");
            }
        }
    }
}
