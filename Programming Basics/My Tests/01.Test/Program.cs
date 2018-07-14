using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            //var firstname = Console.ReadLine();

            //var lastname = Console.ReadLine();

            //var age = int.Parse(Console.ReadLine());

            //var town = Console.ReadLine();
            //Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",
            //    firstname, lastname, age, town);

            decimal counter = 0;

            for (int i1 = 1; i1 <= 44; i1++)
            {
                for (int i2 = i1+1; i2 <= 45; i2++)
                {
                    for (int i3 = i2+1; i3 <= 46; i3++)
                    {
                        for (int i4 = i3+3; i4 <= 47; i4++)
                        {
                            for (int i5 = i4+1; i5 <= 48; i5++)
                            {
                                for (int i6 = i5+1; i6 <= 49; i6++)
                                {
                                    counter++;
                                    

                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);

        }
    }
}