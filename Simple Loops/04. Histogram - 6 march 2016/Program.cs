using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram___6_march_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;

            double u200 = 0.0;
            double u400 = 0.0;
            double u600 = 0.0;
            double u800 = 0.0;
            double u1000 = 0.0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num >= 800 && num <= 1000)
                {
                    u1000++;
                }
                else if (num >= 600)
                {
                    u800++;
                }
                else if (num >= 400)
                {
                    u600++;
                }
                else if (num >= 200)
                {
                    u400++;
                }
                else if (num > 0)
                {
                    u200++;
                }
            }
            Console.WriteLine("{0:f2}%", ((u200/n)*100));
            Console.WriteLine("{0:f2}%", (u400 / n) * 100);
            Console.WriteLine("{0:f2}%", (u600 / n) * 100);
            Console.WriteLine("{0:f2}%", (u800 / n) * 100);
            Console.WriteLine("{0:f2}%", (u1000 / n) * 100);
        }
    }
}
