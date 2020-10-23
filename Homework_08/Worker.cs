using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Worker : IWorker
    {
        public string Name { get; set; }

        public void DoWork(House house)
        {
            for (int i = 0; i < house.parts.Count; i++)
            {
                if (house.parts[i].Status == Status.INPROCESS)
                {
                    house.parts[i].Status = Status.READY;
                    return;
                }
            }
        }
    }
}
