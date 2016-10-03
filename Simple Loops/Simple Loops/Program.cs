using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            int strLength = str.Length;
            int sumChar = 0;

            for (int i = 0; i < strLength; i++)
            {
                switch (str[i])
                {
                    case 'a': sumChar = sumChar + 1; break;
                    case 'e': sumChar = sumChar + 2; break;
                    case 'i': sumChar = sumChar + 3; break;
                    case 'o': sumChar = sumChar + 4; break;
                    case 'u': sumChar = sumChar + 5; break;
                }
            }
            Console.WriteLine(sumChar);
        }
    }
}
