using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string projectionType = Console.ReadLine();
            int rolls = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            var ticketPrice = 0.0;

            int allSeats = rolls * columns;
            /*

            if (projectionType == "Premiere")
            {
                ticketPrice = 12.00;
            }
            else if (projectionType == "Normal")
            {
                ticketPrice = 7.50;
            }
            else if (projectionType == "Discount")
            {
                ticketPrice = 5.00;
            }

            Console.WriteLine("{0:f2} leva", ticketPrice*allSeats);
            */

            switch (projectionType)
            {
                case "Premiere":
                    ticketPrice = 12.00;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5.00;
                    break;

             }
            Console.WriteLine("{0:f2} leva", ticketPrice * allSeats);

        }
    }
}
