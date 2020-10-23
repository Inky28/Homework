using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Basement : IPart
    {
        public string Material { get; set; }
        public Status Status { get; set; }

        public Basement(string material = "Solid", Status status = Status.INPROCESS)
        {
            Material = material;
            Status = status;
        }

        public override string ToString()
        {
            return ($"Basement, material: {Material}, Status: {Status}");
        }
    }
}
