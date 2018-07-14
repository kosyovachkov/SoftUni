using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstatuchnoDelenie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsTrue = false;

            if (38800 % 10 != 0)
            {
                IsTrue = true;
            }

            Console.WriteLine(IsTrue);
        }
    }
}
