using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{Name} {Surname}: {Salary}$";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is Employee)
            {
                var employee = obj as Employee;
                return Name == employee.Name && Surname == employee.Surname && Salary == employee.Salary;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
