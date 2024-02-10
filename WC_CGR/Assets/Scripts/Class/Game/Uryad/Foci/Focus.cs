using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts.Class.Game.Uryad.Foci;
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
        public PrevFoc prevFoc = new PrevFoc();
        public Vector2 position;
        public bool isDost = true;
        public bool isFoc;      
    }
}
