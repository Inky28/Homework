/*
 Напишіть клас Rectangle, який містить:
- змінні-члени, що описують ширину та висоту прямокутника
- стандартний та перевантажений конструктори
- стандартні методи методи доступу
- метод, що обчислює площу прямокутника
- метод Draw для виводу прямокутника на екран
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
            Rectangle test = new Rectangle();
            test.Print();
            test.Draw();
            Console.WriteLine($"Area {test.GetType().Name} = {test.GetArea()}");

            Rectangle test1 = new Rectangle(6, 4);
            test1.Print();
            test1.Draw();
            Console.WriteLine($"Area {test1.GetType().Name} = {test1.GetArea()}");
        }
    }
}
