using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();   
            try
            {
                long n = long.Parse(text);

                Console.WriteLine("{0} can fit in:", n);

                if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (n >= 0 && n <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (n >= short.MinValue && n <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }

                if (n >= 0 && n <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }

                if (n >= int.MinValue && n <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }

                if (n >= 0 && n <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }

                if (n >= long.MinValue && n <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch 
            {

                Console.WriteLine("{0} can't fit in any type", text);
                
            }

        }
    }
}
