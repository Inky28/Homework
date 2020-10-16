using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_Task02
{
    class Employeе
    {
        private string name;
        private string surname;
        private double salary;

        public string Name
        {
            get => name;
            set
            {
                foreach (var c in value.ToLower())
                {
                    if (c < 'a' || c > 'z')
                        throw new Exception("Invalid name");
                }

                name = value;
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                foreach (var c in value.ToLower())
                {
                    if (c < 'a' || c > 'z')
                        throw new Exception("Invalid surname");
                }

                surname = value;
            }
        }
        public double Salary
        {
            get => salary;
            set
            {
                if (salary > 0)
                    salary = value;
                else
                    salary = 0;
            }
        }

        public Employeе(string name = "None", string surname = "None", double salary = 0)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public void EnterEmployee()
        {
            string str;
            bool isValid;
            do
            {
                isValid = true;
                Console.Write("Enter name: ");
                str = Console.ReadLine();
                try
                {
                    Name = str;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isValid = false;
                }
            } while (!isValid);

            do
            {
                isValid = true;
                Console.Write("Enter surname: ");
                str = Console.ReadLine();
                try
                {
                    Surname = str;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isValid = false;
                }
            } while (!isValid);

            do
            {
                isValid = true;
                Console.Write("Enter salary: ");
                str = Console.ReadLine();
                try
                {
                    Salary = double.Parse(str);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    isValid = false;
                }
            } while (!isValid);
        }

        public override string ToString()
        {
            return $"{Name} {Surname}: {Salary}$";
        }
    }
}
