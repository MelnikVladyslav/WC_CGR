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

        public StartGame(List<Parametr> parametrs) 
        {
            this.parametrs = parametrs;
        }
    }
}
