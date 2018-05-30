using System;

namespace NastyHacks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInteger = false;
            bool isInt1 = false;
            bool isInt2 = false;
            bool isInt3 = false;
            int N = 0;
            int r = 0;
            int e = 0;
            int c = 0;
            string input = Console.ReadLine();
            isInteger = int.TryParse(input, out N);

            if (isInteger && N < 101 && N > 0)
            {
                for (int i = 0; i < N; i++)
                {
                    input = Console.ReadLine();
                    try
                    {
                        string[] inputs = input.Split(' ');

                        isInt1 = int.TryParse(inputs[0], out r);
                        isInt2 = int.TryParse(inputs[1], out e);
                        isInt3 = int.TryParse(inputs[2], out c);

                        if (isInt1 && isInt2 && isInt3 && r >= -1000000 && r <= 1000000 && e >= -1000000 && e <= 1000000 && c >= 0 && c <= 1000000)
                        {
                            if (r > (e - c))
                            {
                                Console.WriteLine("do not advertise");
                            }

                            else if (r == e - c)
                            {
                                Console.WriteLine("does not matter");
                            }

                            else
                            {
                                Console.WriteLine("advertise");
                            }
                        }
                    }
                    catch { }

                }
            }

        }
    }
}
