using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            if (oper == "+")
            {
                Console.Write($"{firstNum} + {secondNum} = {firstNum+secondNum} - ");
                Console.WriteLine((firstNum + secondNum)%2==0 ? "even": "odd");
            }
            else if (oper == "-")
            {
                Console.Write($"{firstNum} - {secondNum} = {firstNum - secondNum} - ");
                Console.WriteLine((firstNum - secondNum) % 2 == 0 ? "even" : "odd");
            }
            else if (oper == "*")
            {
                Console.Write($"{firstNum} * {secondNum} = {firstNum * secondNum} - ");
                Console.WriteLine((firstNum * secondNum) % 2 == 0 ? "even" : "odd");
            }
            else if (oper == "/")
            {
                if (secondNum == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNum} / {secondNum} = {((firstNum * 1.0) / secondNum):F2}");
                }
                
            }
            else if (oper == "%")
            {
                if (secondNum == 0)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNum} % {secondNum} = {firstNum % secondNum}");
                }
                
            }
        }
    }
}
