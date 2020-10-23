using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Wall : IPart
    {
        public string Material { get; set; }
        public Status Status { get; set; }

        public Wall(string material = "Brick", Status status = Status.INPROCESS)
        {
            Material = material;
            Status = status;
        }

        public override string ToString()
        {
            return ($"Wall, material: {Material}, Status: {Status}");
        }
    }
}
