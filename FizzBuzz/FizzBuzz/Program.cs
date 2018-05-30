using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int Y = 0;
            int Z = 0;
            
            bool isX = false;
            bool isY = false;
            bool isZ = false;

            string input = Console.ReadLine();

            try
            {
                string[] inputs = input.Split(' ');
                isX = Int32.TryParse(inputs[0], out X);
                isY = Int32.TryParse(inputs[1], out Y);
                isZ = Int32.TryParse(inputs[2], out Z);

                if (isX && isY && isZ && X > 0 && X < 101 && Y > 0 && Y < 101 && Z > 0 && Z < 101)
                {
                    for (int i = 1; i <= Z; i++)
                    {
                        if (i % X == 0 && i % Y == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else if (i % X == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (i % Y == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            catch { }
        }
    }
}
