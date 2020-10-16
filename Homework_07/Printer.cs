using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    class Printer : IPrintInformation
    {
        public string GetName()
        {
            return this.GetType().Name;
        }

        public void Print(string str)
        {
            Console.WriteLine(str);
        }
    }
}
