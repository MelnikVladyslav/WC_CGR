using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Army.Shablons
{
    [Serializable]
    public class Rotes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pidrozdil> batalions = new List<Pidrozdil>();
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
