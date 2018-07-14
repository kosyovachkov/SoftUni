using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 0; i < countSequences; i++)
        {
            long[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            bool found = false;

            List<long> finalResults = new List<long>();

            for (int j = 0; j < numbers.Length; j++)
            {

                long currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    finalResults.Add(currentNum);

                    //Console.Write(currentNum);
                    //Console.Write(" ");
                    found = true;
                }
                else
                {
                    if (j + 1== numbers.Length)
                    {
                        break;
                    }
                    else
                    {
                        currentNum += numbers[j + 1];//Тук при крайна отрицателна стойност излизам от масива, трябва да се подсигуря по някакъв начин

                        if (currentNum >= 0)
                        {
                            finalResults.Add(currentNum);
                            //Console.Write(currentNum);
                            //Console.Write(" ");
                            found = true;
                            j++;
                        }
                        else
                        {
                            j++;
                        }
                    } 
                }

            }


            if (!found)
            {
                Console.WriteLine("(empty)");
            }

            else
            {
                Console.WriteLine(String.Join(" ", finalResults));
            }


        }
    }
}