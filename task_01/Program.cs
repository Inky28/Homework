using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 public sealed class Circle {
 private double radius;
 
 public double Calculate(Func<double, double> op) {
   return op(radius);
 }
}

Написати код на C# для обчислення довжини кола, без зміни класу circle
 */

namespace task_01
{
    public sealed class Circle
    {
        private double radius;

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine($"Length: {circle.Calculate(radius => 2 * Math.PI * radius)}");
        }
    }
}
