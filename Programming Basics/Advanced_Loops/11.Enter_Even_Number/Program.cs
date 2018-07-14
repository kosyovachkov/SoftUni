using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter even number: ");
                int number = int.Parse(Console.ReadLine());

                while (number % 2 != 0)
                {
                    Console.WriteLine("The number is not even.");
                    Console.Write("Enter even number: ");
                    number = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Even number entered: {0}", number);



            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!");

            }
        }
    }
}
