using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delenie_bez_ostatak___26_mart_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num%2==0.0)
                {
                    p1++;
                }
                if (num % 3 == 0.0)
                {
                    p2++;
                }
                if (num % 4 == 0.0)
                {
                    p3++;
                }
            }
            Console.WriteLine("{0:f2}%", (p1 / n) *100);
            Console.WriteLine("{0:f2}%", (p2 / n) * 100);
            Console.WriteLine("{0:f2}%", (p3 / n) * 100);
        }
    }
}
