using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Army.Shablons
{
    [Serializable]
    public class Divisions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Rotes> rotes = new List<Rotes>();
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
