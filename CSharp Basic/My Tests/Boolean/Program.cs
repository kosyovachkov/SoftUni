using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
            //string newBoolean = Console.ReadLine();
            //bool isBool = Convert.ToBoolean(newBoolean);

            int n = int.Parse(Console.ReadLine());
            bool isBool = false;
            if (n==5)
            {
                isBool = true;
            }

            if (isBool)
            {
                Console.WriteLine("number is 5");
            }

            else
            {
                Console.WriteLine("number is no 5");
            }

            
        }
    }
}
