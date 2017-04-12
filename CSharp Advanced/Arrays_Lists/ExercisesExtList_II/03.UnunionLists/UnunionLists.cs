namespace _03.UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UnunionLists
    {
        public static void Main()
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 0; j < secondNumbers.Count; j++)
                {

                    if (!firstNumbers.Contains(secondNumbers[j]))
                    {
                        firstNumbers.Add(secondNumbers[j]);
                        secondNumbers.Remove(secondNumbers[j]);
                        j--;
                    }
                }

                for (int j = 0; j < secondNumbers.Count; j++)
                {
                    if (firstNumbers.Contains(secondNumbers[j]))
                    {
                        firstNumbers.RemoveAll(item => item == secondNumbers[j]);
                    }
                   
                }

                
            }

            firstNumbers.Sort();

            Console.WriteLine(string.Join(" ", firstNumbers));
        }
    }
}

