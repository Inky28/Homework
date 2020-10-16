using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
    class SaySomething : MenuItem
    {
        public SaySomething()
        {
            Text = "Hello world";
        }

        public override void Execute()
        {
            Console.WriteLine("Hello world.");
            System.Threading.Thread.Sleep(2000);
        }
    }
}
