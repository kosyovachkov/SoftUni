using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine().TrimStart(new char[] { '0' });
            string text2 = Console.ReadLine().TrimStart(new char[] { '0' });
            StringBuilder result = new StringBuilder();
            if (text1.Length > text2.Length)
            {
                text2 = text2.PadLeft(text1.Length, '0');
            }
            else if (text1.Length < text2.Length)
            {
                text1 = text1.PadLeft(text2.Length, '0');
            }
            char[] string1 = text1.ToCharArray();
            char[] string2 = text2.ToCharArray();

            int sum = 0;
            int restNum = 0;
            for (int i = string1.Length - 1; i >= 0; i--)
            {
                int num1 = int.Parse(string1[i].ToString());
                int num2 = int.Parse(string2[i].ToString());
                num1 += restNum;
                restNum = 0;
                if (num1 + num2 < 10)
                {
                    result.Append(num1 + num2);
                }
                else
                {
                    sum = (sbyte)((num1 + num2) % 10);
                    result.Append(sum);
                    restNum = (sbyte)((num1 + num2) / 10);
                }
            }
            if (restNum != 0)
            {
                result.Append(restNum);
            }

            char[] endResult = result.ToString().ToCharArray();
            Array.Reverse(endResult);

            Console.WriteLine(string.Join("", endResult));
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _06.SumBigNumbers
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string textOne = Console.ReadLine();
//            string textTwo = Console.ReadLine();

//            List<int> sum = new List<int>();

//            if (textOne.Length == textTwo.Length)
//            {
//                sum = SumCommonNumbers(textOne, textTwo);
//            }

//            else if (textOne.Length > textTwo.Length)
//            {
//                string textOneLastPart = textOne.Substring(textOne.Length - textTwo.Length);
//                List<int> firstSum = SumCommonNumbers(textOneLastPart, textTwo);
//                sum = SumAllNumbers(textOne, textTwo, firstSum);
//            }

//            else
//            {
//                string textTwoLastPart = textTwo.Substring(textTwo.Length - textOne.Length);
//                List<int> firstSum = SumCommonNumbers(textTwoLastPart, textOne);
//                sum = SumAllNumbers(textTwo, textOne, firstSum);
//            }

//            sum.Reverse();
//            Console.WriteLine(string.Join("", sum));

//        }

//        private static List<int> SumAllNumbers(string textOne, string textTwo, List<int> firstSum)
//        {
//            string textOneRest = textOne.Substring(0, textOne.Length - textTwo.Length);
//            int restNum = 0;



//            for (int i = 0; i < textOneRest.Length; i++)
//            {
//                if (firstSum[firstSum.Count - 1-i] == 0)
//                {
//                    restNum = 1;
//                }

//                int lastIndex = textOneRest.Length - 1-i;
//                int lastCharTextOneRest = (textOneRest[lastIndex - i] + restNum) - '0';
//                firstSum.Add(lastCharTextOneRest);
//            }

//            return firstSum;



//        }


//        private static List<int> SumCommonNumbers(string textOne, string textTwo)
//        {
//            List<int> finalSum = new List<int>();

//            int restNum = 0;

//            for (int i = 0; i < textOne.Length; i++)
//            {
//                int lastNumberInList = 0;
//                int lastIndex = textOne.Length - 1;
//                int lastCharTextOne = textOne[lastIndex - i] - '0';
//                int lastChatTextTwo = textTwo[lastIndex - i] - '0';
//                lastNumberInList = lastCharTextOne + lastChatTextTwo + restNum;

//                if (lastNumberInList > 10 && i == 0)
//                {
//                    finalSum.Add(lastNumberInList % 10);
//                    restNum = 1;
//                }

//                else if (lastNumberInList > 10 && i != 0)
//                {
//                    finalSum.Add(lastNumberInList % 10);
//                    restNum = 1;
//                }

//                else if (lastNumberInList < 10)
//                {
//                    finalSum.Add(lastNumberInList);
//                    restNum = 0;
//                }

//                else if (lastNumberInList == 10)
//                {
//                    finalSum.Add(0);
//                    restNum = 1;
//                }

//            }
//            return finalSum;
//        }
//    }
//}
