using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            var workers = new List<IWorker>()
            {
                new Worker() { Name = "Name1" },
                new Worker() { Name = "Name2" },
                new TeamLeader { Name = "Temaleder" }
            };

            Team team = new Team(house, workers);

            house.ShowStatus();
            team.BuildHouse();
            house.ShowStatus();

            Console.WriteLine(team.GetTeamLeaderReports());
        }
    }
}
