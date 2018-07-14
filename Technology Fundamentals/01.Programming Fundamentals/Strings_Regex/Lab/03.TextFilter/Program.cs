using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var banword in banList)
            {
                text = text.Replace(banword, new string('*', banword.Length));
            }

            Console.WriteLine(text);
        }
    }
}
