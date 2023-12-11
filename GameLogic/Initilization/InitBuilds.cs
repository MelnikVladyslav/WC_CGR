using GameLogic.Classes.Game.Economic.Builds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitBuilds
    {
        public List<Build> InitCivil()
        {
            List<Build> builds = new List<Build>()
            {
                new Build()
                {
                    Id = 0,
                    Name = "Цивільні фабрики",
                    Cost = 1000
                },
                new Build()
                {
                    Id = 1,
                    Name = "Інфаструктура",
                    Cost = 100
                }
            };
            return builds;
        }

        public List<ArmyBuild> InitArmy()
        {
            List<ArmyBuild> armyBuilds = new List<ArmyBuild>()
            {
                new ArmyBuild()
                {
                    Id = 0,
                    Name = "Військові заводи",
                    Cost = 1200
                }
            };
            return armyBuilds;
        }

        public List<DefendBuild> InitDefend()
        {
            List<DefendBuild> defendBuilds = new List<DefendBuild>()
            {
                new DefendBuild()
                {
                    Id = 0,
                    Name = "Укріплення",
                    Cost = 500,
                    Attack = 5,
                    Defend = 5
                },
                new DefendBuild()
                {
                    Id = 1,
                    Name = "ППО",
                    Cost = 500,
                    Attack = 5,
                    Defend = 5
                }
            };
            return defendBuilds;
        }
    }
}
