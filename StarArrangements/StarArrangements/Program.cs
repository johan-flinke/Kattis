using System;
using System.Collections.Generic;

namespace StarArrangements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfstars = 0;
            bool cnt = false;
            int row1 = 0;
            int row2 = 0;
            List<int> candidates = new List<int>();

            while(cnt==false)
            {
                string input = Console.ReadLine();
                bool isNUmber = int.TryParse(input, out numberOfstars);
                if (isNUmber)
                {
                    if (numberOfstars > 2 && numberOfstars < 32768)
                    {
                        cnt = true;
                    }
                }

            }
            List<string> a = new List<string>();

            for (int i = 1; i <= (numberOfstars/2)+1; i++)
            {
                for (int j = 1; j <= (numberOfstars/2)+1; j++)
                {
                    int suspect1 = ((i+1)*j);
                    int suspect2 = (i*j);
                    int suspect3 = 2 * suspect1;

                    if ((numberOfstars % (suspect1 + suspect2) == 0) )
                    {
                        Console.WriteLine("Found one (phased)" + suspect1 + "," + suspect2);
                        a.Add(suspect1+","+suspect2 );
                    }

                    if ((numberOfstars % (suspect1 + suspect1) == 0) )
                    {
                        Console.WriteLine("Found one (symetrical)" + suspect1 + "," + suspect1);
                        a.Add(suspect1 + "," + suspect1);
                    }

                    if ((numberOfstars % (suspect3 + suspect2) == 0) )
                    {
                        Console.WriteLine("Found one (multiple)" + suspect3 + "," + suspect2);
                        a.Add(suspect3 + "," + suspect2);
                    }
                }
            }

            //ToDo Applicera korrekta regler.
            // Om antalet rader tillsammans = antalet stjärnor har vi bara en lång kolumn med en stjärna i varje rad---tas bort

            // Om avståndet mellan de bägge talen är mer än 1 så måste talen skalas ned.
            // Kolla först om det ordnar sig om man delar det ena talet med 2. ex) 4,1 => 2,1,2 dvs 2,1
            // Vad händer i fallet 4,2? ska man skala ned bägge till 2,1? eller bara ena till 2,2?

            Console.WriteLine("Färdig");
        }
    }
}
