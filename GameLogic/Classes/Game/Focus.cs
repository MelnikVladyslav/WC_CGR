using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game
{
    [Serializable]
    public class Focus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int KilkDay { get; set; }
        public int KilkDayRemained { get; set;}
        public List<Parametr> parametrs { get; set; }
        public List<Condition> conditions { get; set; }
        public Effect effect { get; set; }
        public Focus prevFoc { get; set; }
        public Vector2 position { get; set; }
        public bool isRes { get; set; }
        public bool isFoc { get; set;}
    }
}
