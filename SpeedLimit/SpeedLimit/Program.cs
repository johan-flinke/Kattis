using System;

namespace SpeedLimit
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int counter = 0;
            int number1 = 0;
            int number2 = 0;
            int lastHour = 0;
            int miles = 0;
            bool isInteger = false;
            bool isnum1 = false;
            bool isnum2 = false;
            bool cnt = true;

            do
            {
                
                string input = Console.ReadLine();
                isInteger = Int32.TryParse(input, out N);
                if (N == -1)
                {
                    cnt = false;
                    break;
                }
                if (isInteger && N <= 10 && N >= 1)
                {
                    for (int i = 0; i < N; i++)
                    {
                        input = Console.ReadLine();
                        try
                        {
                            string[] inputs = input.Split(' ');
                            isnum1 = Int32.TryParse(inputs[0], out number1);
                            isnum2 = Int32.TryParse(inputs[1], out number2);

                            if (isnum1 && isnum2 && number1 <= 90 && number1 >= 1 && number2 <= 90 && number2 >= 1)
                            {
                                miles += number1 * (number2 - lastHour);
                                lastHour = number2;
                            }
                        }
                        catch
                        {
                            cnt = false;
                        }
                    }

                    if (cnt == true)
                    {
                        Console.WriteLine(miles + " miles");
                    }
                   
                    miles = 0;
                    lastHour = 0;
                    counter++;
                }
            } while (cnt && counter <10);
        }
    }
}
