using System;
using System.Linq;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInteger1 = false;
            bool isInteger2 = false;
            int number1 = 0;

            int number2 = 0;
            int biggest = number2;
            string output = "";
            string num1rev = "";
            string num2rev = "";

            string input = Console.ReadLine();
            try
            {
                if (!input.Contains('0'))
                {
                    string[] numbers = input.Split(' ');
                    if (numbers[0].Length == 3 && numbers[1].Length == 3 && !numbers[0].Equals(numbers[1]))

                    {
                        isInteger1 = int.TryParse(numbers[0], out number1);
                        isInteger2 = int.TryParse(numbers[1], out number2);

                        if (isInteger1 && isInteger2)
                        {

                            for (int i = numbers[0].Length - 1; i >= 0; i--)
                            {
                                num1rev += numbers[0].Substring(i, 1);
                            }

                            for (int i = numbers[1].Length - 1; i >= 0; i--)
                            {
                                num2rev += numbers[1].Substring(i, 1);
                            }

                            number1 = int.Parse(num1rev);
                            number2 = int.Parse(num2rev);

                            if (number1 > number2)
                            {
                                biggest = number1;

                            }
                            else
                            {
                                biggest = number2;
                            }

                            Console.WriteLine(biggest);
                        }

                    }
                }
            }
            catch { }

        }
    }
}
