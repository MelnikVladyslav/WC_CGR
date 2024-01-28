using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Economic.Builds
{
    [Serializable]
    public class DefendBuild : Build
    {
        public float Attack { get; set; }
        public float Defend { get; set; }
    }
}
