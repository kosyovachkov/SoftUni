using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool isBool = Convert.ToBoolean(text);
            if (isBool)
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
