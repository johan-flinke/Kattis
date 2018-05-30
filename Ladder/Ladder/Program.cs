using System;

namespace Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int height=0;
            double ladderLength;
            int angle=0;
            double radianAngle = 0;
            double ground;
            bool isHeight = false;
            bool isAngle = false;

            string input = Console.ReadLine();
            try
            {
                string[] Input = input.Split(' ');
                height = Convert.ToInt32(Input[0]);
                angle = Convert.ToInt32(Input[1]);

                isHeight = int.TryParse(Input[0], out height);
                isAngle = int.TryParse(Input[1], out angle);
            }
            catch 
            {
               
            }

            if (isHeight && isAngle)
            {
                if (height > 0 && height < 10001 && angle > 0 && angle < 90)
                {
                    radianAngle = angle * Math.PI / 180;

                    ground = height / Math.Tan(radianAngle);
                    ladderLength = Math.Sqrt((ground * ground) + (height * height));

                    int ans = Convert.ToInt32(Math.Ceiling(ladderLength));
                    Console.WriteLine(ans);
                }
            }
        }
    }
}
