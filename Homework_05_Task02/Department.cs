using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_Task02
{
    class Department
    {
        const int maxEmployees = 10;
        public List<Employeе> Employeеs { get; set; } = new List<Employeе>();

        public void AddToDepartament(Employeе employeе)
        {
            if (Employeеs.Count + 1 <= 10)
            {
                Employeеs.Add(employeе);
            }
            else
            {
                throw new OverflowException("Max employees is 10");
            }
        }

        public void RemoveEmployee(int index)
        {
            if (Employeеs.Count > 0 && index >= 0 && index < Employeеs.Count)
            {
                Employeеs.RemoveAt(index);
            }
            else
            {
                throw new Exception("Departament is empty");
            }
        }
    }
}
