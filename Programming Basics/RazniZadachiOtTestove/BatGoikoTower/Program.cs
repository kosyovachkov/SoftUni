using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikoTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outerDots = n - 1;
            int innerElements = (2 * n) - (outerDots * 2);
            int counterDashes = 0;


            //first row
            Console.WriteLine("{0}/\\{0}", new string('.', outerDots));
            outerDots--;

            //other rows

            try
            {
                for (int row = 1; row < n; row++)
                {


                    Console.WriteLine("{0}/{1}\\{0}", new string('.', outerDots), new string('-', innerElements));
                    counterDashes++;

                    outerDots--;
                    innerElements += 2;

                    for (int i = 1; i <= counterDashes; i++)
                    {
                        Console.WriteLine("{0}/{1}\\{0}", new string('.', outerDots), new string('.', innerElements));

                        outerDots--;
                        innerElements += 2;
                    }



                    }
                }


            catch (Exception)
            {

            }

        }
    }


}

