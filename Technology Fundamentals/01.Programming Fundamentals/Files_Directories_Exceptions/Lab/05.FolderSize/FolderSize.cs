using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



public class FolderSize
{
    static void Main(string[] args)
    {
        string[] files = Directory.GetFiles("TestFolder");

        double sum = 0;

        foreach (var file in files)
        {
            FileInfo info = new FileInfo(file);
            sum += info.Length;
        }

        sum = sum / 1024 / 1024;
        File.WriteAllText("output.txt", sum.ToString());
    }
}

