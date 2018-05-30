using System;

namespace JudgingMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isIntegerR = false;
            bool isIntegerL = false;

            int left = 0;
            int right = 0;
            int point = 0;

            string input = Console.ReadLine();
            try
            {
                string[] inputs = input.Split(' ');
                isIntegerL = Int32.TryParse(inputs[0], out left);
                isIntegerR = Int32.TryParse(inputs[1], out right);

                if (isIntegerL && isIntegerR && left >= 0 && left <= 20 && right >= 0 && right <= 20)
                {
                    if (left == right)
                    {
                        if (left == 0)
                        {
                            Console.WriteLine("Not a moose");
                        }
                        else
                        {
                            point = left + right;
                            Console.WriteLine("Even " + point);
                        }
                    }
                    else
                    {
                        if (left > right)
                        {
                            point = 2 * left;
                            Console.WriteLine("Odd " + point);
                        }
                        else
                        {
                            point = 2 * right;
                            Console.WriteLine("Odd " + point);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
