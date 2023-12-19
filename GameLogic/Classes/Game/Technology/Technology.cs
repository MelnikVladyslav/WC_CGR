using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Economic.Builds;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Technology
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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeTech Type { get; set; }
        public bool IsRes { get; set; }
        public bool IsTech = false;
        public int KilkDay { get; set; }
        public int KilkDayRemained { get; set; }
        public Technology prevTech { get; set; }
        public Weapon weapon { get; set; }
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
