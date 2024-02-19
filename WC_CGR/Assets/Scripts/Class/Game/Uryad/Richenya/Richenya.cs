using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Uryad.Richenya
{
    [Serializable]
    public class Richenya
    {
        public int Id;
        public string Name;
        public string Description;
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
