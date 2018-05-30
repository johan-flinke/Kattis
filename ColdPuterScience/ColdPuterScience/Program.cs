using System;

namespace ColdPuterScience
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int t = 0;
            int temp;
            int counter = 0;
            string[] inputArray = new string[0];

            bool isNumeric = false;
            bool ctn = false;

            while (n<1 || n>100)
            {
                string input = Console.ReadLine();
                isNumeric = int.TryParse(input, out n);
            }
            
            while (ctn == false)
            {
                string input = Console.ReadLine();
                
                inputArray = input.Split(' ');

                if (inputArray.Length == n)
                {
                    for (int i = 0; i < n; i++)
                    {
                        bool isNum = (int.TryParse(inputArray[i], out temp));
                        if (isNum == false)
                        {
                            isNumeric = false;
                        }
                    }

                    if (isNumeric)
                    {
                        ctn = true;
                    }
                    else
                    {
                        Console.WriteLine("Not numeric");
                    }
                }

                else
                {
                    Console.WriteLine("Wrong input");
                }

                
            }

            foreach (var i in inputArray)
            {
                if (Convert.ToInt32(i) < 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
