using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Standart
{
    [Serializable]
    public class Condition
    {
        public int Id;
        public string Name;
        public string Description;
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
