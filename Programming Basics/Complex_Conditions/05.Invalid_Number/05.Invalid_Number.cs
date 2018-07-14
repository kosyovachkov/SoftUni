using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (!(x == 0 || 100 <= x && x <=200))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
