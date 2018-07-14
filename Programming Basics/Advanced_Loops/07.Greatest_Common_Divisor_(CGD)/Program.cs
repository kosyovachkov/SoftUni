using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int maxNum = Math.Max(a, b);
            int minNum = Math.Min(a, b);
            

            while (minNum != 0)
            {
                int newNum = maxNum % minNum;
                maxNum = minNum;
                minNum = newNum;
            }

            Console.WriteLine(maxNum);



        }
    }
}
