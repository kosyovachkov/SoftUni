using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;




class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger num = BigFactoriel(n);

        TrailinZeros(num);
    }

    public static BigInteger BigFactoriel(int n)
    {
        BigInteger factorial = 1;

        for (int i = n; i > 0; i--)
        {
            factorial *= i;
        }

        return factorial;
    }

    public static void TrailinZeros(BigInteger n)
    {
        int count = 0;

        while (n % 10 == 0)
        {
            BigInteger last = n % 10;
            count++;
            n = n / 10;
        }




        Console.WriteLine(count);
    }
}