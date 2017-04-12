namespace _05.NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NoteStatistics
    {
        public static void Main()
        {
            decimal[] input = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            List<string> allNotes = new List<string>();
            List<string> naturalNotes = new List<string>();
            List<string> sharpNotes = new List<string>();
            decimal naturalSum = 0;
            decimal sharpSum = 0;

            foreach (var item in input)
            {
                if (item == 261.63M)
                {
                    allNotes.Add("C");
                    naturalNotes.Add("C");
                    naturalSum += 261.63M;
                }
                else if (item == 277.18M)
                {
                    allNotes.Add("C#");
                    sharpNotes.Add("C#");
                    sharpSum += 277.18M;
                }
                else if (item == 293.66M)
                {
                    allNotes.Add("D");
                    naturalNotes.Add("D");
                    naturalSum += 293.66M;
                }
                else if (item == 311.13M)
                {
                    allNotes.Add("D#");
                    sharpNotes.Add("D#");
                    sharpSum += 311.13M;
                }
                else if (item == 329.63M)
                {
                    allNotes.Add("E");
                    naturalNotes.Add("E");
                    naturalSum += 329.63M;
                }
                else if (item == 349.23M)
                {
                    allNotes.Add("F");
                    naturalNotes.Add("F");
                    naturalSum += 349.23M;
                }
                else if (item == 369.99M)
                {
                    allNotes.Add("F#");
                    sharpNotes.Add("F#");
                    sharpSum += 369.99M;
                }
                else if (item == 392.00M)
                {
                    allNotes.Add("G");
                    naturalNotes.Add("G");
                    naturalSum += 392.00M;
                }
                else if (item == 415.30M)
                {
                    allNotes.Add("G#");
                    sharpNotes.Add("G#");
                    sharpSum += 415.30M;
                }
                else if (item == 440.00M)
                {
                    allNotes.Add("A");
                    naturalNotes.Add("A");
                    naturalSum += 440.00M;
                }
                else if (item == 466.16M)
                {
                    allNotes.Add("A#");
                    sharpNotes.Add("A#");
                    sharpSum += 466.16M;
                }
                else if (item == 493.88M)
                {
                    allNotes.Add("B");
                    naturalNotes.Add("B");
                    naturalSum += 493.88M;
                }
                
                
            }

            Console.WriteLine("Notes: {0}", string.Join(" ", allNotes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", naturalNotes));
            Console.WriteLine("Sharps: {0}", string.Join(", ", sharpNotes));
            Console.WriteLine("Naturals sum: {0}", naturalSum);
            Console.WriteLine("Sharps sum: {0}", sharpSum);
        }
    }
}
