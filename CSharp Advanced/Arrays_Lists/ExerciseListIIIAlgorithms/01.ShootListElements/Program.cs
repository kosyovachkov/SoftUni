using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            double sum = 0;
            double average = 0;

            int lastRemovedInt = 0;
            bool isAnybody = true;

            while (!input.Equals("stop"))
            {
                if (!input.Equals("bang"))
                {
                    int num = int.Parse(input);
                    numbers.Insert(0, num);
                    sum = numbers.Sum();
                    average = sum / numbers.Count;
                }

                else
                {
                    if (numbers.Count == 0)
                    {
                        isAnybody = false;
                        
                        break;
                    }

                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (numbers[i] <= average && numbers.Count > 0)
                        {
                            Console.WriteLine($"shot {numbers[i]}");
                            lastRemovedInt = numbers[i];
                            numbers.RemoveAt(i);

                            for (int j = 0; j < numbers.Count; j++)
                            {
                                numbers[j]--;
                            }

                            sum = numbers.Sum();
                            average = sum / numbers.Count;
                            break;
                        }
                        //else if (numbers.Count == 1)
                        //{
                        //    Console.WriteLine($"you shot them all. last one standing was {numbers[0]}");
                        //    break;
                        //}

                       
                    }

                }


                input = Console.ReadLine();
            }

            if (!isAnybody)
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastRemovedInt}");
            }

            else if (numbers.Count > 1)
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedInt}");
            }
        }
    }
}
