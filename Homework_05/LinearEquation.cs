using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    class LinearEquation
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double x { get; private set; }
        public LinearEquation(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double Calculate()
        {
            try
            {
                if (a == 0)
                    throw new DivideByZeroException();
                x = -1 * b / a;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Variable a cant be 0.");
                throw;
            }
            return x;
        }

        public void Print()
        {
            try
            {
                Calculate();
                Console.WriteLine($"{a} * {x} + {b} = 0");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine($"{a} * x + {b} = 0");
            }
        }

        public void Parse(string str)
        {
            try
            {
                str.Replace(" ", "");
                var strings = str.Split('+');
                if (strings[0].Contains("x"))
                {
                    a = double.Parse(strings[0].Replace("x", ""));
                    b = double.Parse(strings[1]);
                }
                else
                {
                    b = double.Parse(strings[0]);
                    a = double.Parse(strings[1].Replace("x", ""));
                }
            }
            catch
            {
                Console.WriteLine("Invalid string.");
                throw new FormatException();
            }
        }
    }
}
