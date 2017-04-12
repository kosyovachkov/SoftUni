using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int number = Convert.ToInt32(text, 16);

            Console.WriteLine(number);
        }
    }
}
