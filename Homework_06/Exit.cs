using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
    class Exit : MenuItem
    {
        public Exit()
        {
            Text = "Exit";
        }

        public override void Execute()
        {
            System.Environment.Exit(0);
        }
    }
}
