/*
 Дано текст. Вивести статистику  зустрічі у тексті лат букв у вигляді гістограми(цикл по буквах алфавіту, Count(лямбда))
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03_Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "When in the chronicle of wasted time I see descriptions of the fairest wights";
            
            Console.WriteLine($"Str: {str}");

            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                Console.WriteLine($"{ch}: {str.Count(c => char.ToLower(c) == ch)}");
            }
        }
    }
}
