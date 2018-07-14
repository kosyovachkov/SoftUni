using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            //int downNumber = upNumber;

            for (int row = 1; row <= n; row++)
            {
                int downNumber = n;
                int upNumber = row;
                for (int col = 1; col <= n; col++)
                {
                   

                    if (upNumber>=n)
                    {
                        break;
                    }

                    Console.Write("{0} ", upNumber);
                    upNumber++;


                }

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0} ", downNumber);
                    downNumber--;
                }

                Console.WriteLine();

            }

        }
    }
}
