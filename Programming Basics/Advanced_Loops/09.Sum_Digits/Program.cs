using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;


            do
            {
                int lastDigit = n % 10;
                n = n / 10;
                sum += lastDigit;

                
            } while (n>0);

            Console.WriteLine(sum);



            // drugo moe reshenie

            //int length = n.ToString().Length;



            //for (int i = 0; i < length; i++)
            //{
            //    int lastDigit = n % 10;
            //    n = n / 10;
            //    sum += lastDigit;
            //}

            ////Console.WriteLine(length);
            //Console.WriteLine(sum);
        }
    }
}
