namespace RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RoliTheCoder
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, List<string>>> finalData = new Dictionary<string, Dictionary<string, List<string>>>();

            while (!input.Equals("Time for Code"))
            {
                string[] inputData = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string id = inputData[0];
                string eventName = inputData[1];
                if (!eventName.Contains('#'))
                {
                    input = Console.ReadLine();
                    continue;
                }

                else
                {
                    eventName = eventName.Substring(1);
                }

                if (!finalData.ContainsKey(id)) // ако няма ключ - направи
                {
                    finalData[id] = new Dictionary<string, List<string>>();
                }
                else if (!finalData[id].ContainsKey(eventName)) // ако има ключ, но не съдържа името, т.е. има ID и асоциирано с него име - пропусни
                {
                    input = Console.ReadLine();
                    continue;
                }

                finalData[id][eventName] = new List<string>();//ако има празен ключ (само ID) почни да пълниш с инфо.

                for (int i = 2; i < inputData.Length; i++)
                {
                    finalData[id][eventName].Add(inputData[i]);
                }

                finalData[id][eventName].Distinct();

                input = Console.ReadLine();
            }

            foreach (var item in finalData.OrderByDescending(i => i.Value.Values.Sum(p => p.Count)))
            {
                var eventData = item.Value;

                foreach (var pair in eventData)
                {
                    
                    Console.WriteLine($"{pair.Key} - {pair.Value.Count}");

                    foreach (var name in pair.Value.OrderBy(x => x))
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}


