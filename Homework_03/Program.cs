// Дано речення. Знайти найдовше та найкоротше слово.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string minWord, maxWord;
            string row = "When in the chronicle of wasted time I see descriptions of the fairest wights";
            var words = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            minWord = maxWord = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                if (minWord.Length > words[i].Length)
                    minWord = words[i];
                if (maxWord.Length < words[i].Length)
                    maxWord = words[i];
            }

            Console.WriteLine($"Row: {row}");
            Console.WriteLine($"Min word: {minWord}");
            Console.WriteLine($"Max word: {maxWord}");
        }
    }
}
