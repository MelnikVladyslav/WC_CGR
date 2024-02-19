using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Uryad.Persons
{
    [Serializable]
    public class Generals : Person
    {
        public int AttackB;
        public int DefenceB;
        public int MoveB;
        public List<Parametr> parametrs = new List<Parametr>();
        public Parametr Price;
    }
}
