using System;

namespace SolvingForCarrots
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cnt = false;
            int number1;
            int number2;
            do
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                number1 = Convert.ToInt32(inputArray[0]);
                number2 = Convert.ToInt32(inputArray[1]);
                if ((number1 > 0 && number1 < 1001) && (number2 > 0 && number2 < 1001))
                {
                    cnt = true;
                }

            } while(cnt == false);

            for (int i = 0; i < number1; i++)
            {
                Console.ReadLine();
            }

            Console.WriteLine(number2);
        }
    }
}
