using Assets.Scripts.Class.Game.Technolog;
using Assets.Scripts.Class.Game.Uryad.Foci;
using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Economic.Builds;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Technolog
{
    public enum TypeTech
    {
        Army = 0,
        Economic,
        Tech
    }

    [Serializable]
    public class Technology
    {
        public int Id;
        public string Name;
        public string Description;
        public TypeTech Type;
        public bool IsRes;
        public bool IsTech = false;
        public int KilkDay;
        public int KilkDayRemained;
        public PrevTech prevTech = new PrevTech();
        public Weapon weapon;
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
