using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;



            for (int i = 0; i < numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    sum1 += n;
                }

                else if (i % 3 == 1)
                {
                    sum2 += n;
                }

                else if (i % 3 == 2)
                {
                    sum3 += n;
                }

                //for (int j = i; j <= numbers; j++)
                //{
                //    for (int k = i + 1; k < numbers; k++)
                //    {
                //        for (int l = i + 2; l <= numbers; l++)
                //        {
                //            sum3 += n;
                //        }
                //        sum2 += n;
                //    }
                //    sum1 += n;
                //}






            }



            Console.WriteLine("Sum1 = {0}", sum1);
            Console.WriteLine("Sum2 = {0}", sum2);
            Console.WriteLine("Sum3 = {0}", sum3);
        }
    }
}
