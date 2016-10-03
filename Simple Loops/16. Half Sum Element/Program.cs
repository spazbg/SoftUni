using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxNum = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int curruntNum = int.Parse(Console.ReadLine());

                sum = sum + curruntNum;

                if (curruntNum > maxNum)
                {
                    maxNum = curruntNum;
                }
                
            }
            if (sum-maxNum == maxNum)
            {
                Console.WriteLine("Yes\nSum = {0}", sum - maxNum);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(sum-maxNum-maxNum));
            }
        }
    }
}
