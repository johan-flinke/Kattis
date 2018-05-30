using System;

namespace PizzaCrust
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cnt = false;
            bool isDigit = false;
            int R = 8;
            int C = 2;

            while (cnt == false)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');

                if (inputArray.Length > 1)
                {
                    isDigit = int.TryParse(inputArray[0], out R);
                    isDigit = int.TryParse(inputArray[1], out C);

                    if (isDigit)
                    {
                        if (C >= 1 && C <= 100 && R >= 1 && R <= 100 && R >= C)
                        {
                            cnt = true;
                        }

                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Not a correct input");
                    }
                }
            }

            decimal aR = (decimal)Math.PI * R * R;
            decimal aC = (decimal)Math.PI * (R-C) * (R-C);

            decimal percentage =  (aC / aR);

            Console.WriteLine("{0:F6}",percentage*100);
        }
    }
}
