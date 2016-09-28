using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Coding 101 Exam - 6 March 2016

namespace _03.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hh = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine());
            int hh1 = int.Parse(Console.ReadLine());
            int mm1 = int.Parse(Console.ReadLine());
            int allMin = mm + hh * 60;
            int allMin1 = mm1 + hh1 * 60;

            var differenceTime = allMin1 - allMin;

            if (-30 <= differenceTime && differenceTime <= 0)
            {
                if (differenceTime == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceTime));
                }

            }
            else if (differenceTime < -30)
            {
                if (-60 < differenceTime && differenceTime < -30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceTime));
                }
                else if (differenceTime <= -60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", Math.Abs(differenceTime / 60), Math.Abs(differenceTime % 60));
                }

            }
            else if (differenceTime > 0)
            {

                if (differenceTime < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", differenceTime);
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:00} hours after the start", differenceTime / 60, differenceTime % 60);
                }
            }


        }
    }
}