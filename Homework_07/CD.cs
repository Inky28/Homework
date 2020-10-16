using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    class CD : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get => hasDisk; }


        public override string GetName()
        {
            return this.GetType().Name;
        }
        public void Insert()
        {
            if (!hasDisk)
            {
                Console.WriteLine($"{GetName()} inserted.");
                hasDisk = true;
            }
            else
            {
                Console.WriteLine($"{GetName()} already inserted.");
            }
        }

        public void Reject()
        {
            if (hasDisk)
            {
                Console.WriteLine($"{GetName()} rejected.");
                hasDisk = false;
            }
            else
            {
                Console.WriteLine($"{GetName()} does not exist.");
            }
        }
    }
}
