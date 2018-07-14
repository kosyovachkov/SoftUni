namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetArmada
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionAndActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> legionAndSoldiers = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                int activity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (!legionAndSoldiers.ContainsKey(legionName))
                {
                    legionAndSoldiers[legionName] = new Dictionary<string, long>();
                    legionAndActivity[legionName] = activity;
                }

                if (!legionAndSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionAndSoldiers[legionName][soldierType] = 0;
                }
                legionAndSoldiers[legionName][soldierType] += soldierCount;


                if (legionAndActivity[legionName] < activity)
                {
                    legionAndActivity[legionName] = activity;
                }
            }

            string[] secondCommand = Console.ReadLine().Split('\\');

            if (secondCommand.Length == 1)
            {
                string type = secondCommand[0];

                foreach (var item in legionAndActivity.OrderByDescending(x => x.Value))
                {
                    foreach (var kvp in legionAndSoldiers.Where(x => x.Key == item.Key))
                    {
                        var soldierInfo = kvp.Value;

                        foreach (var pair in soldierInfo)
                        {
                            if (pair.Key.Contains(type))
                            {
                                Console.WriteLine("{0} : {1}", item.Value, item.Key);
                            }
                        }
                    }
                }
            }

            //Console.WriteLine();

            else if (secondCommand.Length == 2)
            {
                int activityBorder = int.Parse(secondCommand[0]);
                string neededSoldierType = secondCommand[1];

                Dictionary<string, long> results = new Dictionary<string, long>();

                foreach (var kvp in legionAndActivity)
                {
                    if (kvp.Value < activityBorder)
                    {
                        foreach (var item in legionAndSoldiers.Where(x => x.Key == kvp.Key))
                        {
                            var soldierInfo = item.Value;

                            foreach (var soldier in soldierInfo.OrderByDescending(s => s.Value).Where(x => x.Key.Equals(neededSoldierType)))
                            {
                                results[item.Key] = soldier.Value;
                            }
                        }
                    }
                }

                foreach (var result in results.OrderByDescending(x =>x.Value))
                {
                    Console.WriteLine($"{result.Key} -> {result.Value}");
                }


                //Отдолу е решението, което се опитвах да измисля по време на изпита, но не успях и набих резултата в речник (виж горе)

                //foreach (var kvp in legionAndSoldiers.Where(x => x.Value.ContainsKey(neededSoldierType)).OrderByDescending(x => x.Value[neededSoldierType]))
                //{
                //    foreach (var item in legionAndActivity)
                //    {
                //        if (item.Value < activityBorder)
                //        {
                //            Console.WriteLine("{0} -> {1}", item.Value, kvp.Value[neededSoldierType]);
                //        }
                //    }
                //}
            }
        }
    }
}
