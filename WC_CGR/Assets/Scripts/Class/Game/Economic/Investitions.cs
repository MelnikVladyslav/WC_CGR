using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Economic
{
    [Serializable]
    public class Investitions
    {
        public int Id;
        public string Name;
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
