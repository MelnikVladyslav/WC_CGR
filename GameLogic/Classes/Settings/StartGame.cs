using GameLogic.Classes.Game.Foci;
using GameLogic.Classes.Game.Ideologies;
using GameLogic.Classes.Game.Standart;
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
        public List<Ideology> ideologies = new List<Ideology>();

        public StartGame(List<Parametr> parametrs, List<Focus> foci, List<TreeFocuses> treeFocuses, List<Ideology> ideologies) 
        {
            this.parametrs = parametrs;
            this.foci = foci;
            treesFoci = treeFocuses;
            this.ideologies = ideologies;
        }
    }
}
