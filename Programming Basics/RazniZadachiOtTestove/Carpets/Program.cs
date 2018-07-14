using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outerDots = (n - 2) / 2;
            int innerSpaces = 1;


            //first line
            // Console.WriteLine("{0}/\\{0}", new string('.', outerDots));

            // outerDots--;

            //to middle

            for (int i = 1; i <= n / 2; i++)
            {

                if (i % 2 != 0)
                {
                    Console.Write(new string('.', outerDots));
                    for (int j = 1; j <= i / 2; j++)
                    {
                        Console.Write("/ ");
                    }
                    Console.Write('/');
                    for (int j = 1; j <= i / 2; j++)
                    {
                        Console.Write("\\ ");
                    }
                    Console.Write('\\');
                    Console.WriteLine(new string('.', outerDots));

                }

                else
                {
                    Console.Write(new string('.', outerDots));
                    for (int j = 1; j <= i / 2; j++)
                    {
                        Console.Write("/ ");
                    }
                    Console.Write(" ");
                    for (int j = 1; j < i / 2; j++)
                    {
                        Console.Write("\\ ");
                    }
                    Console.Write('\\');
                    Console.WriteLine(new string('.', outerDots));
                }

                outerDots--;


            }
            outerDots++;

            for (int i = n / 2 - 1; i >= 0; i--)
            {

                if (i % 2 != 0)
                {
                    Console.Write(new string('.', outerDots));
                    for (int j = 0; j <= i / 2; j++)
                    {
                        Console.Write("\\ ");
                    }


                    for (int j = 0; j <= i / 2; j++)
                    {
                        Console.Write(" /");
                    }

                    Console.WriteLine(new string('.', outerDots));

                }

                else
                {
                    Console.Write(new string('.', outerDots));
                    for (int j = 0; j < i / 2; j++)
                    {
                        Console.Write("\\ ");
                    }
                    Console.Write("\\");
                    Console.Write("/");

                    for (int j = 0; j < i / 2; j++)
                    {
                        Console.Write(" /");
                    }


                    Console.WriteLine(new string('.', outerDots));
                }

                outerDots++;


            }
        }
    }
}
