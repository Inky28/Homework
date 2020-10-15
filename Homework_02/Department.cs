using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    class Department
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public List<Employee> list = new List<Employee>();

        public Department(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Number: {Number}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void AddEmployee(Employee employee)
        {
            list.Add(employee);
        }
        public void DeleteEmployeeByName(string name, string surname)
        {
            list.Remove(list.Find(x => x.Name == name && x.Surname == surname));
        }

        public void UpdateEmployeeByName(string name, string surname, string newName, string newSurname, int newSalary)
        {
            var employe = list.Find(x => x.Name == name && x.Surname == surname);
            employe.Name = newName;
            employe.Surname = newSurname;
            employe.Salary = newSalary;
        }
    }
}
