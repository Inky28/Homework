using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class House
    {
        private Basement basement;
        private List<Wall> walls = new List<Wall>();
        private Door door;
        private List<Window> windows = new List<Window>();
        private Roof roof;

        public List<IPart> parts { get; private set; }

        public House()
        {
            basement = new Basement();
            walls.Add(new Wall());
            walls.Add(new Wall());
            walls.Add(new Wall());
            walls.Add(new Wall());
            door = new Door();
            windows.Add(new Window());
            windows.Add(new Window());
            windows.Add(new Window());
            windows.Add(new Window());
            roof = new Roof();

            parts = new List<IPart>();
            parts.Add(basement);
            parts.AddRange(walls);
            parts.Add(door);
            parts.AddRange(windows);
            parts.Add(roof);
        }

        public bool GetStatus()
        {
            foreach (var item in parts)
            {
                if (item.Status == Status.INPROCESS)
                    return false;
            }
            return true;
        }

        public void ShowStatus()
        {
            if (GetStatus())
            {
                Console.WriteLine("Completed");
            }
            else
            {
                Console.WriteLine("In process");
            }
        }
    }
}
