using System;

namespace ReversedBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = "";
            string reversebinary = "";
            int X = 0;
            int Y = 0;
            bool isNumber = false;

            try
            {
                string input = Console.ReadLine();
                isNumber = int.TryParse(input, out X);

                if (isNumber && X<1000000001 && X>0)
                {
                    binary = Convert.ToString(X, 2);
                }

                for (int i = binary.Length-1; i >= 0; i--)
                {
                    reversebinary += binary.Substring(i, 1);
                }

                Y = Convert.ToInt32(reversebinary,2);

                Console.WriteLine(Y);
            }
            catch { }
        }
    }
}
