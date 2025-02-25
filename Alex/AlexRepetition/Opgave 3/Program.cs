namespace Opgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int weight = 60;
            double height = 1.70;
            double BMI = weight / (height * height);
            int number = 0;

            if (BMI <= 18.4)
            {
                number = 1;
            }
            if (BMI >= 18.5 && BMI <= 24.9)
            {
                number = 2;
            }
            if (BMI >= 25 && BMI <= 29.9)
            {
                number = 3;

            }
            if (BMI > 30)
            {
                number = 4;
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine($"BMI is {BMI}, your're underweight");
                    break;

                case 2:
                    Console.WriteLine($"BMI is {BMI}, your're normalweight");
                    break;
                
                case 3:
                    Console.WriteLine($"BMI is {BMI}, your're overweight");
                    break;

                case 4:
                    Console.WriteLine($"BMI is {BMI}, your're obese");
                    break;
                    
                    
            }

            Console.ReadKey();


        }
    }
}
