using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Team
    {
        public List<IWorker> Workers { get; set; }
        public House CurrentHouse { get; set; }

        public Team(House house = null, List<IWorker> workers = null)
        {
            CurrentHouse = house;
            Workers = workers;
        }

        public List<StringBuilder> GetTeamLeaderReports()
        {
            foreach (var item in Workers)
            {
                if (item is TeamLeader)
                    return ((TeamLeader)item).Reports;
            }
            return null;
        }

        public void BuildHouse()
        {
            while (!CurrentHouse.GetStatus())
            {
                foreach (var item in Workers)
                {
                    item.DoWork(CurrentHouse);
                }
            }
        }
    }
}
