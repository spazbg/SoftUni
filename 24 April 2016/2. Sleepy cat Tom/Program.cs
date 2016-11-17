using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sleepy_cat_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            int totalPlayTime;
            totalPlayTime = (holidays * 127) + ((365 - holidays) * 63);

            int differences = 30000 - totalPlayTime;
            

            if (differences > 0)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", differences/60, differences%60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(differences) / 60, Math.Abs(differences) % 60);
            }
        }
    }
}
