using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


public class WordCount
{
    static void Main(string[] args)
    {
        string[] words = File.ReadAllText("words.txt").ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] text = File.ReadAllText("text.txt").ToLower().Split(new[] { ' ', ',', '.', '!', '?', '\r', '\n', '"', '\'', '-' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> results = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < text.Length; j++)
            {
                if (words[i].Equals(text[j]))
                {
                    count++;
                    results[words[i]] = count; 
                }
            }
        }

        foreach (var item in results.OrderByDescending(x => x.Value))
        {
            File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}\r\n");
        }
    }
}

