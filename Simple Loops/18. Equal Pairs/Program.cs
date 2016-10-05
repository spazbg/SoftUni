using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNum;
            int secondNum;

            int previousPair = 0;
            int thisPair = 0;

            int difference = 0;
            int maxDiff =0;

            for (int i = 0; i < n; i++)
            {
                firstNum = int.Parse(Console.ReadLine());
                secondNum = int.Parse(Console.ReadLine());

                if (i==0)
                {
                    previousPair = firstNum + secondNum;
                }

                thisPair = firstNum + secondNum;

                if (thisPair != previousPair)
                {
                    difference = previousPair - thisPair;

                    if (Math.Abs(difference) > Math.Abs(maxDiff))
                    {
                        maxDiff = Math.Abs(difference);
                    }

                }

                previousPair = thisPair;
            }
            if (maxDiff != 0)
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value={0}", previousPair);
            }
        }
    }
}
