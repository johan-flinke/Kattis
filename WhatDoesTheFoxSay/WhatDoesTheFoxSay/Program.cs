using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDoesTheFoxSay
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = 0;
            string animalSounds = "";
            
            List<string> recordedSounds = new List<string>();
            List<string> explicitSounds = new List<string>();
            try
            {
                testCases = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < testCases; i++)
                {
                    animalSounds = Console.ReadLine();
                    animalSounds.ToLower();

                    while (animalSounds != "what does the fox say?")
                    {
                        animalSounds = Console.ReadLine();
                        recordedSounds.Add(animalSounds);
                    }


                }


                
            }
            catch { }
        }
    }
}
