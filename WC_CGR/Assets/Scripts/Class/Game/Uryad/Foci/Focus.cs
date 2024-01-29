using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Classes.Game.Standart;

namespace GameLogic.Classes.Game.Uryad.Foci
{
    [Serializable]
    public class Focus
    {
        public int Id;
        public string Name; 
        public string Description;
        public int KilkDay;
        public int KilkDayRemained;
        public List<Parametr> parametrs = new List<Parametr>();
        public List<Condition> conditions = new List<Condition>();
        public Effect effect;
        public Focus prevFoc;
        public Vector2 position;
        public bool isRes;
        public bool isFoc;      
    }
}
