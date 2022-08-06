using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SumOfTheAlphabets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter a word: ");
            wordSum(Console.ReadLine());
            Console.ReadKey();
        }

        static void wordSum(string word)
        {
            word = word.ToUpper();
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                var c = Convert.ToInt16(word[i]);
                if (c < 65 || c > 90) continue;
                sum += c - 64;
            }
            Console.WriteLine(sum);

        }

    }
}
