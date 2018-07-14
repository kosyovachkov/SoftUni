using System;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(new string('*', n));

        //for (int i = 0; i < n-2; i++)
        //{
        //    Console.WriteLine("*" + new string (' ', n-2) + '*');
        //}

        //Console.WriteLine(new string('*', n));

        for (int i = 0; i < n; i++)
        {
            Console.Write('*');
        }

        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('*');

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write(" ");
            }

            Console.WriteLine('*');
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
    }
}

