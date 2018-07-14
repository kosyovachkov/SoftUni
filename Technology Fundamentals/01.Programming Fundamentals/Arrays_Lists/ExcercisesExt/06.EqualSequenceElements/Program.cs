using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualSequenceElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isEqual = true;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != arr[i+1])
                {
                    isEqual = false;
                    break;
                }

               
            }
            if (isEqual)
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
