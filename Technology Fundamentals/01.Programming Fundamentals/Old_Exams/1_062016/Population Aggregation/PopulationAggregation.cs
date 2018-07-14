namespace Population_Aggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class PopulationAggregation
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"[#$@&0-9]");

            SortedDictionary<string, long> countryData = new SortedDictionary<string, long>();
            Dictionary<string, long> cityData = new Dictionary<string, long>();

            while (!input.Equals("stop"))
            {
                string[] countriesInput = input.Split('\\');

                string country = string.Empty;
                string city = string.Empty;
                long population = long.Parse(countriesInput[2]);

                string firstInput = countriesInput[0];
                MatchCollection first = regex.Matches(firstInput);

                foreach (Match matches in first)
                {
                    firstInput = regex.Replace(firstInput, "");
                }

                string secondInput = countriesInput[1];

                MatchCollection second = regex.Matches(secondInput);
                foreach (Match matches in second)
                {
                    secondInput = regex.Replace(secondInput, "");
                }

                if (char.IsUpper(firstInput[0]))
                {
                    country = firstInput;
                    city = secondInput;
                }
                else
                {
                    country = secondInput;
                    city = firstInput;
                }

                if (!countryData.ContainsKey(country))
                {
                    countryData[country] = 0;
                }
                countryData[country]++;

                if (!cityData.ContainsKey(city))
                {
                    cityData[city] = 0;
                }
                cityData[city] = population;


                input = Console.ReadLine();
            }

            foreach (var item in countryData)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var item in cityData.OrderByDescending(c => c.Value).ThenBy(c => c.Key).Take(3))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
