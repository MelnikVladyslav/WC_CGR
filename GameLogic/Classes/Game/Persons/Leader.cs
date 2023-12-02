using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Persons
{
    [Serializable]
    public class Leader : Person
    {
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
