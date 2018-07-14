using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3*n), new string('.', n));

            int outerPoints = n-1;
            int innerPoints = 3 * n;

            for (int i = 1; i < n; i++)
            {
                Console.Write("{0}*{1}*{0}", new string('.', outerPoints), new string('.', innerPoints));
                Console.WriteLine();
                outerPoints--;
                innerPoints += 2;
            }

            Console.WriteLine("{0}", new string('*', 5*n));


            for (int i = 2*n+1; i > 1; i--)
            {
                Console.Write("{0}*{1}*{0}", new string('.', outerPoints+1), new string('.', innerPoints-2));
                Console.WriteLine();
                outerPoints++;
                innerPoints -= 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('.', outerPoints+1), new string('*', n-2));
           
        }
    }
}
