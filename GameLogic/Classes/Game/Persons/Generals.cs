using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Persons
{
    [Serializable]
    public class Generals : Person
    {
        public int AttackB { get; set; }
        public int DefenceB { get; set; }
        public int MoveB { get; set; }
        public List<Parametr> parametrs = new List<Parametr>();
        public Parametr Price { get; set; }
    }
}
