namespace FilesWithClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class File
    {
        public string Drectory { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }

    public class FilesWithClasses
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<File> allFiles = new List<File>();

            for (int i = 0; i < n; i++)
            {
                string[] fileInfo = Console.ReadLine().Split('\\', ';');

                File inputFile = new File();
                inputFile.Drectory = fileInfo[0];
                inputFile.Name = fileInfo[fileInfo.Length - 2];
                inputFile.Size = long.Parse(fileInfo[fileInfo.Length - 1]);

                allFiles.Add(inputFile);
            }

            string[] commands = Console.ReadLine().Split();
            string fileExtension = commands[0];
            string rootDirectiry = commands[2];

            Dictionary<string, long> finalResults = new Dictionary<string, long>(); // създавам речник за по-лесно извеждане на резултаите и защото си осигурявам презаписване на еднкавите ключове, което ми трябва в този случай

            foreach (var item in allFiles)
            {
                //if (item.Drectory.Contains(rootDirectiry) && item.Name.Contains('.' + fileExtension)) - коментираното също е вярно
                //{
                //    if (!finalResults.ContainsKey(item.Name))
                //    {
                //        finalResults[item.Name] = item.Size;
                //    }
                //    finalResults[item.Name] = item.Size;
                //}

                if (item.Drectory.Contains(rootDirectiry) && item.Name.EndsWith(fileExtension))
                {
                    finalResults[item.Name] = item.Size; //понеже винаги трябва да записвам последната стойност не е необходимо да правя проверки дали ключа съществува
                }

            if (finalResults.Count==0)
            {
                Console.WriteLine("No");
            }

            else
            {
                 foreach (var files in finalResults.OrderByDescending(f => f.Value).ThenBy(f =>f.Key))
            {
                Console.WriteLine("{0} - {1} KB ", files.Key, files.Value);
            }
            }

           
        }
    }
}
