namespace Opgave_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool running = true;

            while (running)
            {
                int number = 0;
                Console.WriteLine("Enter a number between 1 and 7: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number >= 1 && number <= 7)
                {
                    Days(number);
                    running = false;
                }

                else
                {
                    Console.WriteLine("Wrong input try again!\n");
                }
               

            }


            

            
            

            Console.ReadKey();
        }


        static void Days(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
