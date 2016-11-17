using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Popravka_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            int sidePlayground = int.Parse(Console.ReadLine());
            double widthTile = double.Parse(Console.ReadLine());
            double longTile = double.Parse(Console.ReadLine());
            int widthBench = int.Parse(Console.ReadLine());
            int longBench = int.Parse(Console.ReadLine());

            double totalPlayground = (sidePlayground * sidePlayground) - (widthBench * longBench);
            double totalTile = totalPlayground / (widthTile * longTile);

            Console.WriteLine(totalTile);
            Console.WriteLine(totalTile*0.2);

        }
    }
}
