namespace Opgave_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number between 1 - 12: ");
            int number = Convert.ToInt32(Console.ReadLine());
                       
            

            switch (number)
            {
                case 1:
                    Console.WriteLine("January is cold");
                    break;

                case 2:
                    Console.WriteLine("February is cold");
                    break;
                case 3:
                    Console.WriteLine("March is mild");
                    break;
                case 4:
                    Console.WriteLine("April is mild");
                    break;
                case 5:
                    Console.WriteLine("May is warm");
                    break;
                case 6:
                    Console.WriteLine("June is warm");
                    break;
                case 7:
                    Console.WriteLine("July is warm");
                    break;
                case 8:
                    Console.WriteLine("August is warm");
                    break;
                case 9:
                    Console.WriteLine("September is mild");
                    break;
                case 10:
                    Console.WriteLine("October is wet");
                    break;
                case 11:
                    Console.WriteLine("November is wet");
                    break;
                case 12:
                    Console.WriteLine("December is wet");
                    break;
            }

            Console.ReadKey();
        }
    }
}
