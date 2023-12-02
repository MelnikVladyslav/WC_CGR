using GameLogic.Classes.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Settings
{
    [Serializable]
    public class StartGame
    {
        public List<Parametr> parametrs = new List<Parametr>();
        public List<Focus> foci = new List<Focus>();
        public List<TreeFocuses> treesFoci = new List<TreeFocuses>();

        public StartGame(List<Parametr> parametrs, List<Focus> foci, List<TreeFocuses> treeFocuses) 
        {
            this.parametrs = parametrs;
            this.foci = foci;
            this.treesFoci = treeFocuses;
        }
    }
}
