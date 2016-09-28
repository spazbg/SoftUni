using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            //logika za tochka v dolnata figura
            if ((x > h && x < 2 * h) && y == h)
            {
                Console.WriteLine("inside");
            }
            else if ((0 <= x && x <= (3 * h)) && (0 <= y && y <= h))
            {
                if ((0 < x && x < (3 * h)) && (0 < y && y < h))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }

            }
            else if ((h <= x && x <= (2 * h)) && (h <= y && y <= (4 * h)))
            {
                if ((h < x && x < (2 * h)) && (h < y && y < (4 * h)))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }

            }

            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}