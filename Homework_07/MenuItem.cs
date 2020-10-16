using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    class MenuItem
    {
        public string Text { get; private set; }

        public Action Execute { get; private set; }

        public MenuItem(string text, Action action)
        {
            Text = text;
            Execute = action;
        }
    }
}
