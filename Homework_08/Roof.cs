using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Roof : IPart
    {
        public string Material { get; set; }
        public Status Status { get; set; }

        public Roof(string material = "Metal tile", Status status = Status.INPROCESS)
        {
            Material = material;
            Status = status;
        }

        public override string ToString()
        {
            return ($"Roof, material: {Material}, Status: {Status}");
        }
    }
}
