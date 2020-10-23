
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09
{
    class Menu
    {
        public string Header { get; set; }
        public bool IsExit { get; private set; }
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        private int selector = 0;
        public void PrintItems()
        {
            Console.Clear();
            if (Header != "" && Header != null)
                Console.WriteLine(Header);
            for (int i = 0; i < MenuItems.Count; i++)
            {
                if (i == selector)
                    Console.Write("> ");
                Console.WriteLine(MenuItems[i].Text);
            }
        }

        public void Move()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.W:
                    selector -= 1;
                    break;
                case ConsoleKey.S:
                    selector += 1;
                    break;
                case ConsoleKey.Enter:
                    MenuItems[selector].Execute();
                    break;
            }

            if (selector < 0)
                selector = MenuItems.Count();
            else if (selector >= MenuItems.Count())
                selector = 0;
        }

        public void Add(MenuItem item)
        {
            MenuItems.Add(item);
        }

        public void Exit()
        {
            IsExit = true;
        }

        public void Start()
        {
            while (!IsExit)
            {
                PrintItems();
                Move();
            }
        }
    }
}
