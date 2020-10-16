/*
 Успадкування. Віртуальні методи. Абстрактний клас. 

Розробити ієрархію класів для системи меню.
 В Вас повинні існувати наступні класи:
- MenuItem, який містить опис окремого пункта меню і включає як мінімум:
     - поле Text, що містить назву пункта меню
     - абстрактний метод void Execute(), який є реакцією на пункт меню
- не меньше 2 похідних класи від класу menuItem, які характеризують окремі пункти меню.
 Наприклад, клас Exit, Help тощо
- клас menu, який містить масив пунктів меню, тобто масив елементів типу MenuItem та метод, 
який дозволяє переглянути меню в цілому
В основній програмі створити меню, заповнити його та виконати.
 Оцінюється якість та реалізація моделі. 

Примітка! Для виходу з середовища використовується метод класу System.Environment Exit().
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Add(new SaySomething());
            menu.Add(new Help());
            menu.Add(new Exit());
            menu.Start();
        }
    }
}
