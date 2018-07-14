namespace _01.DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DistinctList
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    if (input[j] == input[i])
                    {
                        input.RemoveAt(j);
                        j--;
                        
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
