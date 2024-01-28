using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Army.Weaponry
{
    public enum TypeWeapon
    {
        Infantry = 0,
        Artillery,
        Technics,
        Aviations,
        Flot
    }

    [Serializable]
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float ProductionCost { get; set; }
        public TypeWeapon Type { get; set; }
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
