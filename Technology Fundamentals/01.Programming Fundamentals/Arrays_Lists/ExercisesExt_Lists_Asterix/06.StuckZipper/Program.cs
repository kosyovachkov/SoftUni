using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstRow = Console.ReadLine().Split();
            string[] secondRow = Console.ReadLine().Split();

            List<string> newFirst = new List<string>();
            List<string> newSecond = new List<string>();

            int minLength = int.MaxValue;

            for (int i = 0; i < firstRow.Length; i++)
            {
                int numberLength = GetLenght(firstRow[i]);
                if (numberLength<minLength)
                {
                    minLength = numberLength;
                }
            }
            for (int i = 0; i < secondRow.Length; i++)
            {
                int numberLength = GetLenght(secondRow[i]);
                if (numberLength < minLength)
                {
                    minLength = numberLength;
                }
            }

            foreach (var number in firstRow)
            {
                int numberLength = GetLenght(number);
                if (numberLength==minLength)
                {
                    newFirst.Add(number);
                }
            }

            foreach (var number in secondRow)
            {
                int numberLength = GetLenght(number);
                if (numberLength == minLength)
                {
                    newSecond.Add(number);
                }
            }

            List<string> final = new List<string>();

            for (int i = 0; i < Math.Min(newFirst.Count, newSecond.Count); i++)
            {
                final.Add(newSecond[i]);
                final.Add(newFirst[i]);
            }
            if (newFirst.Count>newSecond.Count)
            {
                for (int i = newSecond.Count; i < newFirst.Count; i++)
                {
                    final.Add(newFirst[i]);
                }
            }

            else if (newSecond.Count>newFirst.Count)
            {
                for (int i = newFirst.Count; i < newSecond.Count; i++)
                {
                    final.Add(newSecond[i]);
                }
            }

            Console.WriteLine(string.Join(" ", final));
        }

        private static int GetLenght(string v)
        {
            int length = v.Length;
            if (v[0].Equals('-') )
            {
                length--;
            }

            return length;
        }
    }
}
