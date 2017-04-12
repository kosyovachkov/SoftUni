using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('.', n+1), new string('_', 2*n+1));

            int outerPoints = n;
            int innerDashes = 2 * n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}//{1}\\\\{0}", new string('.', outerPoints), new string('_', innerDashes));
                Console.WriteLine();
                outerPoints--;
                innerDashes += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', n*2-3));

            for (int i = n; i >= 1; i--)
            {
                Console.Write("{0}\\\\{1}//{0}", new string('.', outerPoints), new string('_', innerDashes));
                Console.WriteLine();
                outerPoints++;
                innerDashes -= 2;
            }


        }
    }
}
