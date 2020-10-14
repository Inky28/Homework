/*
 * Подсчитать количество слов во введенном предложении. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Enter text: ");
            str = Console.ReadLine();

            Console.WriteLine("Num of words: {0}", str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length);

        }
    }
}
