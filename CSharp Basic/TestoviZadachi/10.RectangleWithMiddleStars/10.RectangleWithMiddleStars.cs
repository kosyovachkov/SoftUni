using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RectangleWithMiddleStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            //first last lines

            Console.WriteLine(new string('%', n * 2));

            // middle part

            if (n % 2 == 1)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n * 2 - 2)));
                    Console.WriteLine("%");
                }

                Console.Write("%");
                Console.Write(new string(' ', ((n * 2 - 4)) / 2));
                Console.Write("**");
                Console.Write(new string(' ', ((n * 2 - 4)) / 2));
                Console.WriteLine("%");

                for (int i = 1; i <= n / 2; i++)
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n * 2 - 2)));
                    Console.WriteLine("%");
                }

            }
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n / 2-1; i++)
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n * 2 - 2)));
                    Console.WriteLine("%");
                }

                Console.Write("%");
                Console.Write(new string(' ', ((n * 2 - 4)) / 2));
                Console.Write("**");
                Console.Write(new string(' ', ((n * 2 - 4)) / 2));
                Console.WriteLine("%");

                for (int i = 1; i <= n / 2-1; i++)
                {
                    Console.Write("%");
                    Console.Write(new string(' ', (n * 2 - 2)));
                    Console.WriteLine("%");
                }

            }
            //first last lines

            Console.WriteLine(new string('%', n * 2));
        }
    }
}
