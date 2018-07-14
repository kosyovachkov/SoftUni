using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertBseNBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int baseNumber = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            List<BigInteger> newBase = new List<BigInteger>();

            int count = 0;

            while (number > 0)
            {
                BigInteger lastNumber = number % 10;
                newBase.Add(lastNumber * BigInteger.Pow(baseNumber, count));
                number = number / 10;
                count++;
            }

            BigInteger newsum = 0;

            foreach (var item in newBase)
            {
                newsum += item;
            }

            Console.WriteLine(newsum);
        }
    }


    //Друго решение

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] input = Console.ReadLine().Trim().Split();
    //        int baseNNum = int.Parse(input[0]);
    //        char[] baseTenNum = input[1].ToCharArray();

    //        BigInteger result = new BigInteger(0);

    //        for (int i = 0; i < baseTenNum.Length; i++)
    //        {
    //            int currentNum = (int)Char.GetNumericValue(baseTenNum[i]);
    //            result += currentNum * BigInteger.Pow(baseNNum, baseTenNum.Length - i - 1);
    //        }

    //        Console.WriteLine(result);
    //    }
    //}
}