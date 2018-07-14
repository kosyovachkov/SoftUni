using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_From_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            int actualNumber = 1;

            for (int row = 1; row <= actualNumber; row++)
            {

                for (int col = 1; col <= row; col++)
                {
                    if (actualNumber <= number)
                    {
                        Console.Write(actualNumber+" ");
                        actualNumber++;
                    }

                    else
                    {
                        break;
                    }

                }

                Console.WriteLine();

                
                
            }
        }
    }
}
