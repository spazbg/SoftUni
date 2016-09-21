using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var yearType = Console.ReadLine();
            int holidaysP = int.Parse(Console.ReadLine());
            int weekendsOutH = int.Parse(Console.ReadLine());
            double Total = 0.0;

            double daysInSofia = (48 - weekendsOutH) * 3.0 / 4;
            Total = daysInSofia + weekendsOutH + (holidaysP * (2.0 / 3));

            if (yearType == "leap")
            {
                Total = (0.15 * Total) + Total;
                Console.WriteLine(Math.Floor(Total));

            }
            else if (yearType == "normal")
            {
                Console.WriteLine(Math.Floor(Total));
            }
        }
    }
}
