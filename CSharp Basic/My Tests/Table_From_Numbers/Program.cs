using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_From_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int row = 1; row <= number; row++)
            {
                int increase = row;
                int decrease = number;

                for (int col = 1; col <= number; col++)
                {

                    if (increase<number)
                    {
                        Console.Write(increase);
                        increase++;
                    }

                    else
                    {
                        Console.Write(decrease);
                        decrease--;
                    }

                    
                }

                Console.WriteLine();


            }



        }
    }
}

