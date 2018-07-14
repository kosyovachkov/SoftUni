namespace _02.IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IntegerInsertion
    {
        public static void Main()
        {
            List<string> numbersArray = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                int indexToInsert = int.Parse(input[0].ToString());
                numbersArray.Insert(indexToInsert, input);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbersArray));
        }
    }
}
