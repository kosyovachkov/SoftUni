namespace LadyBugsAnotherResolve
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LadyBugsAnotherResolve
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x >= 0 && x < fieldSize)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < indexes.Length; i++)
            {
                int currentLadybugsIndex = indexes[i];
                field[currentLadybugsIndex] = 1;
            }

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                string[] commandLines = command.Split();
                int ladybugIndex = int.Parse(commandLines[0]);
                string direction = commandLines[1];
                int flyLength = int.Parse(commandLines[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                FlyLadybugs(field, ladybugIndex, direction, flyLength);

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static void FlyLadybugs(int[] field, int ladybugIndex, string direction, int flyLength)
        {
            field[ladybugIndex] = 0; //излита и освобождава мястото (индекса)

            bool isOutOrOnPlace = false; //ключов момент

            while (!isOutOrOnPlace)
            {
                switch (direction)
                {
                    case "right":
                        ladybugIndex += flyLength;
                        break;
                    case "left":
                        ladybugIndex -= flyLength;
                        break;
                }

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    isOutOrOnPlace = true;
                    continue;
                }

                if (field[ladybugIndex] == 1)
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    field[ladybugIndex] = 1;
                    isOutOrOnPlace = true;
                    continue;
                }
            }
        }
    }
}
