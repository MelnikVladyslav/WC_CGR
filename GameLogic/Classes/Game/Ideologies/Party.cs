using GameLogic.Classes.Game.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Ideologies
{
    [Serializable]
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Ideology ideology { get; set; }
        public Leader leader { get; set; }
        public DateTime dateCreate { get; set; }
    }
}
