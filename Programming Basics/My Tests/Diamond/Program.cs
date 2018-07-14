using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outerDashes = (n - 1) / 2;

            int asterix = 1;
            if (n % 2 == 0)
            {
                asterix = 2;
            }

            int innerDashes = 1;
            if (n % 2 == 0)
            {
                innerDashes = 2;
            }

            if (n==1)
            {
                Console.WriteLine('*');
            }

            else if (n==2)
            {
                Console.WriteLine("**");
            }

            else
            {

            

            //firts row

            Console.WriteLine("{0}{1}{0}", new String('-', outerDashes), new String('*', asterix), new String('-', outerDashes));

            //to middel part

            outerDashes--;

            for (int i = 2; i <= (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new String('-', outerDashes), new String('-', innerDashes));
                innerDashes += 2;
                outerDashes--;
            }

            //from middle to bottom

            outerDashes++;
            innerDashes -= 2;

            for (int i = (n + 1) / 2 - 1; i >1; i--)
            {
                outerDashes++;
                innerDashes -= 2;
                Console.WriteLine("{0}*{1}*{0}", new String('-', outerDashes), new String('-', innerDashes));
                
            }

            outerDashes++;
            innerDashes -= 2;

            //last row

            Console.WriteLine("{0}{1}{0}", new String('-', outerDashes), new String('*', asterix), new String('-', outerDashes));

            }
        }
    }
}
