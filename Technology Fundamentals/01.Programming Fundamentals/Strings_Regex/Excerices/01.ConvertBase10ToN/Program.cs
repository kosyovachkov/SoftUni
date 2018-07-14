using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertBase10ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int baseNumber = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            List<BigInteger> newBase = new List<BigInteger>();

            while (number > 0)
            {
                newBase.Add(number % baseNumber);
                number = number / baseNumber;
            }

            newBase.Reverse();

            Console.WriteLine(string.Join("", newBase));
        }
    }
}
