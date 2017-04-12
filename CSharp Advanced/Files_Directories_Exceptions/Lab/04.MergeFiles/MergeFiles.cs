using System;
using System.IO;
using System.Collections.Generic;


public class MergeFiles
{
    static void Main()
    {
        string[] fileOne = File.ReadAllLines("FileOne.txt");
        string[] fileTwo = File.ReadAllLines("FileTwo.txt");

        List<int> numbers = new List<int>();

        foreach (var item in fileOne)
        {
            numbers.Add(int.Parse(item));
        }

        foreach (var item in fileTwo)
        {
            numbers.Add(int.Parse(item));
        }

        numbers.Sort();

        foreach (var item in numbers)
        {
            File.AppendAllText("output.txt", item.ToString());
            File.AppendAllText("output.txt", "\r\n");
        }
    }
}

