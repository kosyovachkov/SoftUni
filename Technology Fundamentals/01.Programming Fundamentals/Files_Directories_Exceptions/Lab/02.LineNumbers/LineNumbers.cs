using System;
using System.Collections.Generic;
using System.IO;



public class LineNumbers
{
    static void Main()
    {
        string[] inputLines = File.ReadAllLines("input.txt");

        List<string> newLines = new List<string>();

        for (int i = 0; i < inputLines.Length; i++)
        {
            newLines.Add((i + 1) + ". " + inputLines[i]);
        }

        File.WriteAllLines("output.txt", newLines);
    }
}

