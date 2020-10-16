/*
 Створити додатково клас Department(відділ), що міститиме масив з працівників(Employeе) та 
методи додавання працівників, видалення працівника. 

До класу Employee додати методи вводу імені та прізвища, метод вводу окладу. 
Методи повинні викидати виключення
 - при введені у Імя чи Прізвище недопустимих символів(цифр, чи ін),
 - введенні символьних даних в числові поля(оклад) 
Також виконати перевірку на переповнення даними змінної(checked), що містить значення окладу працівника при збільшенні окладу працівника на деяке число( чи процент)
- запропонувати ввести повторно 

До класу Department додати обробку виключних ситуацій
 - Перевищення розміру масиву працівників відділу
 - Видалення даних з пустого масиву (видалення працівника з відділу, якщо в відділі ще немає жодного працівника) 
У програмі надати користувачу можливість здійснити повторну спробу введення даних.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department();
            Employeе e1 = new Employeе();
            e1.EnterEmployee();
            Console.WriteLine(e1);

            try
            {
                d.RemoveEmployee(0);
                d.AddToDepartament(e1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
