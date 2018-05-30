using System;

namespace NumberFun
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 0;
            double number2 = 0;
            double result = 0;
            bool possible = false;
            bool isInteger = false;
            bool isInteger1 = false;
            bool isInteger2 = false;
            bool isInteger3 = false;
            int N = 0;

            try
            {
                string testCases = Console.ReadLine();
                isInteger = int.TryParse(testCases, out N);

                if (isInteger)
                {
                    for (int i = 0; i < N; i++)
                    {
                        string numbers = Console.ReadLine();
                        string[] inputs = numbers.Split(' ');

                        isInteger1 = double.TryParse(inputs[0], out number1);
                        isInteger2 = double.TryParse(inputs[1], out number2);
                        isInteger3 = double.TryParse(inputs[2], out result);

                        if (isInteger1 && isInteger2 && isInteger3)
                        {
                            possible = false;

                            if (number1 + number2 == result)
                            {
                                possible = true;
                            }

                            if (number1 - number2 == result || number2 - number1 == result)
                            {
                                possible = true;
                            }

                            if (number1 * number2 == result)
                            {
                                possible = true;
                            }

                            if (number1 / number2 == result || number2 / number1 == result)
                            {
                                possible = true;
                            }

                            if (possible)
                            {
                                Console.WriteLine("Possible");
                            }
                            else
                            {
                                Console.WriteLine("Impossible");
                            }
                        }

                    }
                }
            }
            catch { }
        }
    }
}
