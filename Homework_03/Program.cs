/*
 Пользователь вводит строку. Проверить, является ли
эта строка палиндромом. Палиндромом называется
строка, которая одинаково читается слева направо
и справа налево.
 */

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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Exit = 0");
                Console.Write("Enter str: ");

                string str = Console.ReadLine();

                var charStr = str.ToCharArray();

                Array.Reverse(charStr);

                if (str == "0")
                    return;

                if (new string(charStr) == str)
                    Console.WriteLine("Palindrome");
                else
                    Console.WriteLine("Not palindrome");
            }
        }
    }
}
