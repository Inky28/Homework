/*
Створити клас Department, що містить в собі наступні поля:
назва відділу
телефон
масив працівників, що також описаний окремим класом Employee
Даний клас містить набір методів, що дозволяють:
здійснити модифікацію окремих полів класу (імя та прізвище, посаду, оклад)
вивести інформацію про відділ вцілому
додавати / видаляти працівників з/до відділу
змінювати інформацію про працівникі
*/

using System.Collections.Generic;
using System.Dynamic;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Ivan", "Ivanov", 1500);
            Employee e2 = new Employee("Ira", "Grishko", 2500);
            Employee e3 = new Employee("Vika", "Grutsai", 3500);


            Department test = new Department("Building", "BL-130");
            test.AddEmployee(e1);
            test.AddEmployee(e2);
            test.AddEmployee(e3);

            test.Print();

            test.DeleteEmployeeByName("Ivan", "Ivanov");

            test.Print();
        }
    }
}