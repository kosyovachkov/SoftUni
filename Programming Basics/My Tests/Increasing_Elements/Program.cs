using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oldNumber = int.MinValue;
            int curNumber = 0;
            //int n2 = 0;

            int longest = 0;
            int longestNow = 0;



            for (int i = 1; i <= n; i++)
            {
                curNumber = int.Parse(Console.ReadLine());

                if (curNumber > oldNumber)
                {
                    longestNow++;

                    if (longest < longestNow)
                    {
                        longest = longestNow;
                    }
                }

                else
                {

                    if (longest < longestNow)
                    {
                        longest = longestNow;
                       
                    }

                    longestNow = 1;

                }

                oldNumber = curNumber;

            }



            Console.WriteLine(longest);




        }
    }
}
