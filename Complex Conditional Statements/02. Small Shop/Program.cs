using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = decimal.Parse(Console.ReadLine());

            var price = 0.0m;

            if (city == "sofia")
            {
                if (item == "coffee")
                {
                    price = 0.50m;
                }
                else if (item == "water")
                {
                    price = 0.80m;
                }
                else if (item == "beer")
                {
                    price = 1.20m;
                }
                else if (item == "sweets")
                {
                    price = 1.45m;
                }
                else if (item == "peanuts")
                {
                    price = 1.60m;
                }
            }
            if (city == "plovdiv")
            {
                if (item == "coffee")
                {
                    price = 0.40m;
                }
                else if (item == "water")
                {
                    price = 0.70m;
                }
                else if (item == "beer")
                {
                    price = 1.15m;
                }
                else if (item == "sweets")
                {
                    price = 1.30m;
                }
                else if (item == "peanuts")
                {
                    price = 1.50m;
                }
            }
            if (city == "varna")
            {
                if (item == "coffee")
                {
                    price = 0.45m;
                }
                else if (item == "water")
                {
                    price = 0.70m;
                }
                else if (item == "beer")
                {
                    price = 1.10m;
                }
                else if (item == "sweets")
                {
                    price = 1.35m;
                }
                else if (item == "peanuts")
                {
                    price = 1.55m;
                }
            }

            Console.WriteLine("{0}", (price * quantity));
        }
    }
}
