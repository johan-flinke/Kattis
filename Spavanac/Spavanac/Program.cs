using System;

namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = 0;
            int M = 0;
            bool cnt = false;

            while (cnt == false)
            {
                string input = Console.ReadLine();
                string[] inputAsrray = input.Split(' ');

                bool isDigitH = int.TryParse(inputAsrray[0], out H);
                bool isDigitM = int.TryParse(inputAsrray[1], out M);

                if (isDigitH && isDigitM)
                {
                    if (M >= 0 && M <=59 && H >=0 && H <= 23)
                    {
                        if (M > 45)
                        {
                            M -= 45;
                        }

                        else
                        {
                            if (H != 0)
                            {
                                H--;
                            }
                            else
                            {
                                H = 23;
                            }
                           
                            M = (60 - (45 - M));
                        }
                        cnt = true;
                    }
                    
                }
            }

            Console.WriteLine("{0} {1}", H, M);
        }
    }
}
