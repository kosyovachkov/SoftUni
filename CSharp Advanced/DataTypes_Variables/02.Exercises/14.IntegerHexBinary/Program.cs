using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerHexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            string num = Convert.ToString(n, 16).ToUpper();
            string num2 = Convert.ToString(n, 2);
            Console.WriteLine(num);
            Console.WriteLine(num2);
        }
    }
}
