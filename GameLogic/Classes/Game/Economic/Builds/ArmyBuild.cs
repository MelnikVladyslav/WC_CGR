using GameLogic.Classes.Game.Army.Weaponry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Economic.Builds
{
    [Serializable]
    public class ArmyBuild : Build
    {
        public Weapon Weapon { get; set; }
        public float Kilkisty { get; set; }
    }
}
