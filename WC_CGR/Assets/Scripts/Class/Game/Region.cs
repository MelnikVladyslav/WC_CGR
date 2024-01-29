using GameLogic.Classes.Game.Army.Shablons;
using GameLogic.Classes.Game.Economic.Builds;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game
{
    [Serializable]
    public class Region
    {
        public int Id;
        public string Name;
        public string nameCity;
        public List<Build> builds = new List<Build>();
        public List<ArmyBuild> armyBuilds = new List<ArmyBuild>();
        public List<DefendBuild> defendBuilds = new List<DefendBuild>();
        public List<Divisions> divisions = new List<Divisions>();
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
