using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game
{
    [Serializable]
    public class TreeFocuses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Focus> foci { get; set; }
    }
}
