using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b1 = Convert.ToByte(Console.ReadLine());
            //string s1 = Console.ReadLine();
            //string[] sa1 = s1.Split(' ');
            //float f1 = Convert.ToSingle(sa1[0]);
            //float f2 = Convert.ToSingle(sa1[1]);
            //float f3 = Convert.ToSingle(Console.ReadLine());
            //byte b2 = Convert.ToByte(Console.ReadLine());

            //for (int i = 0; i < b2; i++)
            //{
            //    string s2 = Console.ReadLine();
            //    string[] sa2 = s2.Split(' ');
            //    float f4 = Convert.ToSingle(sa2[0]);
            //    float f5 = Convert.ToSingle(sa2[1]);
            //}
            

            //Console.WriteLine(b1);
            //Console.WriteLine(f1);
            //Console.WriteLine(f2);
            //Console.WriteLine(f3);
            //Console.WriteLine(b2);
            //Console.WriteLine(f4);
            //Console.WriteLine(f5);

            byte taxbands = 1;
            float taxbandSize1 = 4750.50f;
            float percentageTaxation1 = 0;

            float taxbandSize2 = 8000f;
            float percentageTaxation2 = 20f;

            float taxbandSize3 = 10000f;
            float percentageTaxation3 = 40f;

            float[] tb1 = {taxbandSize1, percentageTaxation1};
            float[] tb2 = { taxbandSize2, percentageTaxation2 };
            float[] tb3 = { taxbandSize3, percentageTaxation3 };

            List<float[]> taxbandsList = new List<float[]>();
            List<float[]> moneyList = new List<float[]>();

            taxbandsList.Add(tb1);
            taxbandsList.Add(tb2);
            taxbandsList.Add(tb3);

            float percentageRest = 60;
            byte numberOfFriends = 3;

            float moneyEarned1 = 0.0f;
            float giftAmountAfterTax1 = 10000f;

            float moneyEarned2 = 10000f;
            float giftAmountAfterTax2 = 5000f;

            float moneyEarned3 = 15000f;
            float giftAmountAfterTax3 = 5000f;

            float[] m1 = {moneyEarned1, giftAmountAfterTax1};
            float[] m2 = { moneyEarned2, giftAmountAfterTax2 };
            float[] m3 = { moneyEarned3, giftAmountAfterTax3 };

            moneyList.Add(m1);
            moneyList.Add(m2);
            moneyList.Add(m3);

            List<float> theResult = MoneyAmount(taxbandsList, percentageRest, moneyList);
        }

        public static List<float> MoneyAmount(List<float[]> tb, float tax, List<float[]> moneyEarned)
        {
            List<float[]> answerList = new List<float[]>();
            List<float> taxamounts = new List<float>();
            List<float> interval = new List<float>();
            float finalAmount=0;
            float totalMoney = 0;
            float restMoney = 0;
            float currentBand = 0;
            float currentTaxAmount = 0;
            float currentMoneyEarned = 0;
            float currentGift = 0;
            float theTax = 0;
            
            
            //interval.Add(tb.ElementAt(tb.Count-1)[0]);

            for (int i = 0; i < moneyEarned.Count; i++)
            {
                currentMoneyEarned = moneyEarned.ElementAt(i)[0];
                currentGift = moneyEarned.ElementAt(i)[1];
                totalMoney = currentMoneyEarned + currentGift;
                restMoney = totalMoney;

                interval.Add(tb.ElementAt(0)[0]);
                for (int j = 0; j < tb.Count - 1; j++)
                {
                    interval.Add(tb.ElementAt(j + 1)[0] - tb.ElementAt(j)[0]);
                }
                interval.Add(totalMoney-tb.ElementAt(tb.Count-1)[0]);


                for (int k = 0; k < tb.Count; k++)
                {
                    currentBand = tb.ElementAt(k)[0];
                    currentTaxAmount = tb.ElementAt(k)[1];

                    if (totalMoney >= currentBand)
                    {
                        theTax += interval[0] * (currentTaxAmount / 100);
                        
                        restMoney -= interval[0];
                        interval.RemoveAt(0);
                    }

                    else
                    {
                        theTax += restMoney * currentTaxAmount / 100;
                    }
                }

                if (restMoney > 0)
                {
                    theTax += restMoney * (tax / 100);
                }

                //theTax += interval[0] * (currentTaxAmount / 100);
                interval.Clear();
                taxamounts.Add(theTax);
                theTax = 0;
                //currentBand = tb.ElementAt(i)[0];
                //currentTaxAmount = tb.ElementAt(i)[1];
                //currentMoneyEarned = moneyEarned.ElementAt(i)[0];
                //currentGift = moneyEarned.ElementAt(i)[1];
                //totalMoney = currentMoneyEarned + currentGift;

                //if (totalMoney > currentBand)
                //{
                //    theTax += interval[0] * currentTaxAmount;
                //    interval.RemoveAt(0);
                //    taxamounts.Add(theTax);

                //}

                //else
                //{
                //    finalAmount += totalMoney * currentTaxAmount;
                //    break;
                //}


            }

            finalAmount = totalMoney / (1 - tax/100);
            
             
            return taxamounts;
        }
    }
}
