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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Parametr> parametrs { get; set; }
    }
}
