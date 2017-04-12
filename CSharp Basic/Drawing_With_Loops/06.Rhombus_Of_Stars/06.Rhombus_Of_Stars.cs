using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rhombus_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new String(' ', n - 1));
            Console.WriteLine("*");

            

            for (int row = 2; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                    
                }

                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            ///// bottom

            for (int row = n - 2; row >= 1; row--)
            {
                for (int col = 1; col < n - row; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row +1; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            if (n>1)
            {
                Console.Write(new String(' ', n - 1));
                Console.WriteLine("*");
            }

            
        }
    }
}
