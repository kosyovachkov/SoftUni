using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MaxLineGrowingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countMax = 0;
            int countCurrent = 0;
            int maxNumber = int.MinValue; ;



            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());


                if (num > maxNumber)
                {
                    maxNumber = num;
                    countCurrent++;
                }

                else
                {
                    maxNumber = num;
                    countCurrent = 1; //това е важно - не е -1, а 1, т.е. започва да брои отначало следващата поредица от нарастващи числа/
                }


                if (countCurrent > countMax)
                {
                    countMax = countCurrent;
                }
            }

            Console.WriteLine(countMax);
        }
    }
}
