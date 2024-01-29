using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Classes.Game.Standart;

namespace GameLogic.Classes.Game.Uryad.Foci
{
    [Serializable]
    public class Effect
    {
        public int Id;
        public string Name;
        public string Description;
        public List<Parametr> parametrs;
    }
}
