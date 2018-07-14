using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //firts row

            Console.WriteLine("{0}*", new string(' ', n-1));

            //second to middle rows

            string asterixDash = "*-";

            for (int i = 2; i <= n; i++)
            {
                Console.Write(new string(' ', n-i));
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write(asterixDash);
                }

                Console.WriteLine('*');
            }
           

            // middle to last but one row

            for (int i = n-1; i > 1; i--)
            {
                Console.Write(new string(' ', n - i));
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write(asterixDash);
                }

                Console.WriteLine('*');
            }

            //last row

            if (n>1)
            {
                Console.WriteLine("{0}*", new string(' ', n - 1));
            }

            


        }
    }
}
