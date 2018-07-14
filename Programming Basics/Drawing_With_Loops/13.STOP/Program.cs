using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //first line

            Console.WriteLine("{0}{1}{0}", new String('.', n + 1), new String('_', n * 2 + 1));

            //upper lines

            int outsideDots = n;
            int insideDashes = n * 2 - 1;

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new String('.', outsideDots), new String('_', insideDashes));
                outsideDots--;
                insideDashes += 2;
            }

            //stop line

            Console.WriteLine("//{0}STOP!{0}\\\\", new String('_', (insideDashes - 5) / 2));

            //bottom firts line

            Console.WriteLine("\\\\{0}//", new String('_', insideDashes));

            //bottom lines

            outsideDots = 1;
            insideDashes -= 2;


            for (int row = 0; row < n-1; row++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new String('.', outsideDots), new String('_', insideDashes));
                outsideDots++;
                insideDashes -= 2;
            }
        }


    }
}
