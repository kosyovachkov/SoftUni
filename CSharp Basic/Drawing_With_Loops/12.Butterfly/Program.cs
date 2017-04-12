using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ////first line

            //Console.WriteLine("{0}\\-/{0}", new String('*', n-2));

            //// second line

            //Console.WriteLine("{0}\\-/{0}", new String('-', n - 2));

            if (n == 3)
            {
                Console.WriteLine("{0}\\ /{0}", new String('*', n - 2));
                Console.WriteLine("{0}@", new String(' ', n - 1));
                Console.WriteLine("{0}/ \\{0}", new String('*', n - 2));
            }

            else
            {
                if (n > 3 && n % 2 == 0)
                {
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        Console.WriteLine("{0}\\ /{0}", new String('*', n - 2));
                        Console.WriteLine("{0}\\ /{0}", new String('-', n - 2));
                    }
                }

                else if (n > 3 && n / 2 != 0)
                {
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        Console.WriteLine("{0}\\ /{0}", new String('*', n - 2));
                        Console.WriteLine("{0}\\ /{0}", new String('-', n - 2));
                    }
                    Console.WriteLine("{0}\\ /{0}", new String('*', n - 2));

                }

                //middle

                Console.WriteLine("{0}@", new String(' ', n - 1));

                if (n > 3 && n % 2 == 0)
                {
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        Console.WriteLine("{0}/ \\{0}", new String('*', n - 2));
                        Console.WriteLine("{0}/ \\{0}", new String('-', n - 2));
                    }
                }

                else if (n > 3 && n / 2 != 0)
                {
                    for (int i = 0; i < n / 2 - 1; i++)
                    {
                        Console.WriteLine("{0}/ \\{0}", new String('*', n - 2));
                        Console.WriteLine("{0}/ \\{0}", new String('-', n - 2));
                    }
                    Console.WriteLine("{0}/ \\{0}", new String('*', n - 2));

                }
            }
        }
    }
}
