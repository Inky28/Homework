/*
 Розробити власний тип даних для розвязування  лінійного рівняння А*Х + В = 0. 
 У класі визначити 
 Конструктор з 2-ма параметрами, що приймає коефіціенти рівняння
 Метод пошуку розвязку рівняння
 Статичний метод Parse( ), який приймає рядок з значеннями коефіціентів, розділених  пропуском(чи табуляцією)
 У випадку передачі в метод рядка недопустимого формату генерується виключення FormatException.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation le = new LinearEquation(0, 6);
            le.Parse("2x + 3");

            try
            {
                le.Parse("2");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            le.Print();
        }
    }
}
