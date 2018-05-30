using System;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int counter = 0;
            bool cnt = false;

            while (cnt == false)
            {
                counter = 0;
                s = Console.ReadLine();
                //s = null;
                try
                {
                    if (s.Length != 0)
                    {
                        if (s.Length < 1000 && s.Length > 1)
                        {
                            for (int i = 0; i < s.Length; i++)
                            {
                                char c = s.ElementAt(i);
                                if (char.IsLetter(c))
                                {
                                    if (c.Equals('D') || c.Equals('U'))
                                    {
                                        counter++;
                                    }
                                }

                            }
                            if (counter == s.Length)
                            {
                                cnt = true;
                            }
                        }
                    }
                }
                catch { }
                
            }

            char n = Convert.ToChar(s.Substring(0, 1));

            int l = s.Length;
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;

            // 1
            for (int i = 1; i < l; i++)
            {
                if (n.Equals('D'))
                {
                    c1++;
                }

                else
                {
                    if (s[i].Equals('D'))
                    {
                        c1 += 2;
                    }

                }
                n = 'U';
            }

            // 2
            n = Convert.ToChar(s.Substring(0, 1));
            for (int i = 1; i < l; i++)
            {
                if (n.Equals('U'))
                {
                    c2++;
                }

                else
                {
                    if (s[i].Equals('U'))
                    {
                        c2 += 2;
                    }

                }
                n = 'D';
            }

            // 3
            for (int i = 1; i < l; i++)
            {
                n = Convert.ToChar(s[i - 1]);
                if (!n.Equals(s[i]))
                {
                    c3++;
                }
            }
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}
