using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Window : IPart
    {
        public string Material { get; set; }
        public Status Status { get; set; }

        public Window(string material = "Glass", Status status = Status.INPROCESS)
        {
            Material = material;
            Status = status;
        }

        public override string ToString()
        {
            return ($"Window, material: {Material}, Status: {Status.ToString()}");
        }
    }
}
