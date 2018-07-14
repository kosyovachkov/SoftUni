using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //upper towers

            Console.Write("/{0}\\", new String('^', n / 2));

            Console.Write(new string('_', (2 * n) - ((n / 2) + (n / 2)) - 4));

            Console.WriteLine("/{0}\\", new String('^', n / 2));

           
            //middle

            for (int row = 1; row < n - 2; row++)
            {
                Console.WriteLine("|{0}|", new String(' ', n * 2 - 2));
            }


            Console.Write("|{0}", new String(' ', n / 2 + 1));

            Console.Write(new string('_', (2 * n) - ((n / 2) + (n / 2)) - 4));

            Console.WriteLine("{0}|", new String(' ', n / 2 + 1));




            //bottom parts


            Console.Write("\\{0}/", new String('_', n / 2));

            Console.Write(new string(' ', (2 * n) - ((n / 2) + (n / 2)) - 4));

            Console.WriteLine("\\{0}/", new String('_', n / 2));
        }
    }
}
