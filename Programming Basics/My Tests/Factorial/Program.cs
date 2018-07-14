using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal factorial = 1;

            while (n > 1)
            {
                factorial *= n;
                n--;
            }

            Console.WriteLine(factorial);
        }
    }
}
