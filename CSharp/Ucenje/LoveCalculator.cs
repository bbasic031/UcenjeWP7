using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class LoveCalculator
    {
        public static void Calculate()
        {
            string userName, loverName;
            StringBuilder bothNames = new StringBuilder();
            string tempBoth = "";
            string firstRow, secondRow, thirdRow, fourthRow, fifthRow;

            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();
            bothNames.Append(userName);
            bothNames.Append(" ");

            Console.WriteLine("Enter your potential lover's name: ");
            loverName = Console.ReadLine();
            bothNames.Append(loverName);
            tempBoth = bothNames.ToString();

            firstRow = string.Join(" ", tempBoth.ToCharArray());
            secondRow = GetLetterCount(tempBoth);
            thirdRow = AddUpLetters(secondRow);
            fourthRow = AddUpLetters(thirdRow);
            fifthRow = AddUpLetters(fourthRow);

            int maxWidth = firstRow.Length;

            Console.WriteLine(CenterText(firstRow, maxWidth));
            Console.WriteLine(CenterText(secondRow, maxWidth));
            Console.WriteLine(CenterText(thirdRow, maxWidth));
            Console.WriteLine(CenterText(fourthRow, maxWidth));
            Console.WriteLine(CenterText(fifthRow, maxWidth));
        }


        static string GetLetterCount(string input)
        {
            return string.Join(" ", input.Select(c => c == ' ' ? " " : input.Count(ch => ch == c).ToString()));
        }

        static string AddUpLetters(string counts)
        {
            var numbers = counts.Split(' ')
                                .Where(x => !string.IsNullOrWhiteSpace(x))
                                .Select(int.Parse)
                                .ToArray();

            StringBuilder output = new StringBuilder();
            int n = numbers.Length;

            for (int i = 0; i < n / 2; i++)
            {
                output.Append(numbers[i] + numbers[n - 1 - i]).Append(" ");
            }

            if (n % 2 != 0)
            {
                output.Append(numbers[n / 2]).Append(" ");
            }

            return output.ToString().TrimEnd();
        }
        static string CenterText(string text, int maxWidth)
        {
            int spaces = (maxWidth - text.Length) / 2;
            return new string(' ', Math.Max(0, spaces)) + text;
        }
    }
}
