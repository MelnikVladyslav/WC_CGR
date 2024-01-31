using GameLogic.Classes.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Class.Settings
{
    [Serializable]
    public class Players
    {
        public Country Player;
        public List<Country> bots;
    }
}
