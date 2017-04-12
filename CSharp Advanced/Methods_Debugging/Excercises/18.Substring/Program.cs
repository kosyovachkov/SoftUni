using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        //char neededLetter = 'р';
        bool hasMatch = false;


        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == 'p')
            {
                hasMatch = true;

                //int endIndex = jump;

                if (jump > text.Length-i-1)
                {
                    jump = text.Length-i-1;
                }

                string matchedString = text.Substring(i, jump + 1);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}