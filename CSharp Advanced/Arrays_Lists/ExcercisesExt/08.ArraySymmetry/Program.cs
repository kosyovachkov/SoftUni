using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            bool isSymetric = false;

            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i] == arr[arr.Length-i-1])
                {
                    isSymetric = true;
                }
                else
                {
                    isSymetric = false;
                    break;
                }
            }
            if (isSymetric)
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
