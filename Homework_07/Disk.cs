using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_07
{
    class Disk : IDisk
    {
        string memory;
        int memSize;
        public string Memory { get => memory; set => memory = value; }
        public int MemSize { get => memSize; set => memSize = value; }

        public Disk()
        {
            Memory = "Empty";
            MemSize = 0;
        }
        public Disk(string memory, int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }
        public virtual string GetName()
        {
            return "Default name";
        }
        public string Read()
        {
            return memory;
        }

        public void Write(string text)
        {
            if (MemSize == 0)
                Memory = text;
            else
                Memory += text;
            memSize = Memory.Length;
        }
    }
}
