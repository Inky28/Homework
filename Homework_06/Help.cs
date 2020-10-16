using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
    class Help : MenuItem
    {
        public Help()
        {
            Text = "Help";
        }

        public override void Execute()
        {
            Console.WriteLine("For move use W/S");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
