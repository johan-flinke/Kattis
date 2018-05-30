using System;

namespace Faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int I = 0;
            
            bool isNumeric = false;
            bool ctn = false;

            while (ctn == false)
            {
                string input = Console.ReadLine();
                string[] inputArray = input.Split(' ');

                if (inputArray.Length == 2)
                {
                    isNumeric = int.TryParse(inputArray[0], out A);
                    isNumeric = int.TryParse(inputArray[1], out I);
                }

                if (isNumeric)
                {
                    ctn = true;
                }
            }
            Console.WriteLine((A*(I-1))+1);
        }
    }
}
