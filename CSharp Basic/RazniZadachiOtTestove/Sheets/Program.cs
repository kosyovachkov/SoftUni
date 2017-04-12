using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] aArray = { "A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0" };
            for (int i = 10; i >= 0; i--)
            {
                int aSheet = (int)Math.Pow(2.0, (double)i);
                if (n < aSheet)
                {
                    Console.WriteLine(aArray[i]);
                }
                else
                {
                    n -= aSheet;
                }
            }
        }
    }
}



