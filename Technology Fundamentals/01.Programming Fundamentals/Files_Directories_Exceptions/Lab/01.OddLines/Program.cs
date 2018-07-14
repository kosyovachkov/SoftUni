using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            List<string> newlInes = new List<string>();

            for (int i = 1; i < lines.Length; i+=2)
            {
                newlInes.Add(lines[i]);
            }

            File.WriteAllLines("output.txt", newlInes);
        }

        
    }
}
