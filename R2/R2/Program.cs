using System;

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ctn = false;
            int number1=0;
            int number2;
            int mean=0;
            while (ctn == false)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');
                number1 = Convert.ToInt32(inputArray[0]);
                mean = Convert.ToInt32(inputArray[1]);

                if ((number1 >= -1000 && number1 <= 1000) && (mean >= -1000 && mean <= 1000))
                {
                    ctn = true;
                }
            }
            number2 = 2 * mean - number1;
            Console.WriteLine(number2);
        }
    }
}
