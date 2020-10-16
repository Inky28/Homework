using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06
{
    abstract class MenuItem
    {
        public string Text { get; set; }
        virtual public void Execute()
        {
            return;
        }
    }
}
