using GameLogic.Classes.Game.Army.Weaponry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Army
{
    [Serializable]
    public class WeaponRota
    {
        public string weapon { set; get; }
        public int Kilkisty { set; get; }
    }
}
