using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class TeamLeader : IWorker
    {
        public List<StringBuilder> Reports { get; set; }
        public string Name { get; set; }

        public void DoWork(House house)
        {
            if (house.GetStatus())
            {
                return;
            }

            StringBuilder report = new StringBuilder("TeamLeader Report\n");
            foreach (var item in house.parts)
            {
                report.Append(item.ToString() + '\n');
            }
        }
    }
}
