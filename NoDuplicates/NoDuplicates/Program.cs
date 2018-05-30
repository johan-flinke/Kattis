using System;

namespace NoDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "";
            int wordCount = 0;
            bool duplicate = false;
            try
            {
                sentence = Console.ReadLine();
                sentence = sentence.ToUpper();

                if (sentence.Length >= 0 && sentence.Length <= 80)
                {
                    string[] words = sentence.Split(' ');

                    for (int i = 0; i < words.Length; i++)
                    {
                        wordCount = 0;
                        string suspect = words[i];
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (suspect.Equals(words[j]))
                            {
                                wordCount++;
                            }
                        }

                        if (wordCount > 1)
                        {
                            duplicate = true;
                        }
                    }

                    if (duplicate)
                    {
                        Console.WriteLine("no");
                    }
                    else
                    {
                        Console.WriteLine("yes");
                    }
                }
            }
            catch { }
        }
    }
}
