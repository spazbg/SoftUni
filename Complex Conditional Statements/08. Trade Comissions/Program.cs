using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commission = 0.0;

            
            if (city == "sofia")
            {
                if (sales > 10000) commission = 0.12;
                else if (sales > 1000) commission = 0.08;
                else if (sales > 500) commission = 0.07;
                else if (sales > 0) commission = 0.05;
                else Console.WriteLine("error");
            }
            else if (city == "varna")
            {
                if (sales > 10000) commission = 0.13;
                else if (sales > 1000) commission = 0.1;
                else if (sales > 500) commission = 0.075;
                else if (sales > 0) commission = 0.045;
                else Console.WriteLine("error");
            }
            else if (city == "plovdiv")
            {
                if (sales > 10000) commission = 0.145;
                else if (sales > 1000) commission = 0.12;
                else if (sales > 500) commission = 0.08;
                else if (sales > 0) commission = 0.055;
                else Console.WriteLine("error");
            }
            if (commission == 0.0 || (city != "sofia" && city != "varna" && city != "plovdiv"))
            {
                Console.WriteLine("error");
            } 
            else
            {
                Console.WriteLine("{0:f2}", commission * sales);
            }
                
        }
    }
}
