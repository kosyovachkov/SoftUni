using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_With_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //first row

            Console.WriteLine(new String('%', n * 2));


            //middle body

            if (n % 2 == 0)
            {
                for (int row = 1; row <= n - 1; row++)
                {
                    if (row == n / 2)
                    {
                        Console.WriteLine("%{0}**{0}%", new String(' ', (n*2 - 4) / 2));
                    }

                    else
                    {
                        Console.WriteLine("%{0}%", new String(' ', n * 2 - 2));
                    }


                }
            }

            else
            {
                for (int row = 1; row <= n; row++)
                {
                    if (row == n / 2 + 1)
                    {
                        Console.WriteLine("%{0}**{0}%", new String(' ', (n*2 - 4) / 2));
                    }
                    else
                    {
                        Console.WriteLine("%{0}%", new String(' ', n * 2 - 2));
                    }

                }
            }





            //last row

            Console.WriteLine(new String('%', n * 2));
        }
    }
}
