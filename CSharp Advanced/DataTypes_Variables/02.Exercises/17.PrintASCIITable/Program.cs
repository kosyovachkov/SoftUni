using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= lastIndex; i++)
            {
                Console.Write("{0} ", (char)(i));
            }
            Console.WriteLine();
        }
    }
}
