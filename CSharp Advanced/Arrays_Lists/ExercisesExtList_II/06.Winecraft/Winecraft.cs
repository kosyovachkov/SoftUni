namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Winecraft
    {
        public static void Main()
        {
            List<int> grapes = Console.ReadLine().Split().Select(int.Parse).ToList();
            int growthDates = int.Parse(Console.ReadLine());

            while (grapes.Count > growthDates)
            {
                for (int n = 0; n < growthDates; n++)
                {
                    for (int i = 0; i < grapes.Count; i++)
                    {
                        grapes[i]++;
                    }

                    for (int i = 0; i < grapes.Count; i++)
                    {
                        bool firstElement = i == 0;
                        bool lastElement = i == grapes.Count - 1;

                        if (!firstElement && !lastElement)
                        {
                            if (grapes[i] > grapes[i - 1] && grapes[i] > grapes[i + 1])
                            {
                                grapes[i]--;// защото горе сме увеличили всички с едно, а по условие, ако това число е по-голямо от съседните не трябва да се увеличава.

                                if (grapes[i - 1] > 0)
                                {
                                    grapes[i]++;
                                    grapes[i - 1] = Math.Max(grapes[i - 1] - 2, 0);
                                    // защото горе сме увеличили всички с едно, а по условие, ако от това число се вади (до него е по-голямо) не трябва да се увеличава, 
                                    // т.е. първо вадим 1 за да спазим условието да не се увеличава (компенсираме увеличаването в началото на цикъла) 
                                    // и после вадим пак 1 защото до него има по-голямо число, което е между две по-малки, но винаги трябва числото да е по-голямо от 0
                                    // затова използваме Math.Max.
                                }

                                if (grapes[i + 1] > 0)
                                {
                                    grapes[i]++;
                                    grapes[i + 1] = Math.Max(grapes[i + 1] - 2, 0);
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] <= growthDates)
                    {
                        grapes.RemoveAt(i);
                        i--;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
