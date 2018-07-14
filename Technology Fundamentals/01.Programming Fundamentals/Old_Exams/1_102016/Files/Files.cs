using System;
using System.Collections.Generic;
using System.Linq;

class Files
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, Dictionary<string, long>> results = new Dictionary<string, Dictionary<string, long>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split('\\', ';');
            string root = input[0];
            string fileName = input[input.Length - 2];
            long size = long.Parse(input[input.Length - 1]);

            if (!results.ContainsKey(root))
            {
                results[root] = new Dictionary<string, long>();
            }

            if (!results[root].ContainsKey(fileName))
            {
                results[root][fileName] = size;//може да трябва да е 0 в началото - да проверя
            }
            results[root][fileName] = size;
        }

        string[] condition = Console.ReadLine().Split();
        string fileCondition = condition[0];
        string rootCondition = condition[2];

        bool isFound = false;

        foreach (var item in results)
        {
            foreach (var pair in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (item.Key.Equals(rootCondition) && pair.Key.Contains('.' + fileCondition))
                {
                    Console.WriteLine("{0} - {1} KB", pair.Key, pair.Value);
                    isFound = true;
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}

