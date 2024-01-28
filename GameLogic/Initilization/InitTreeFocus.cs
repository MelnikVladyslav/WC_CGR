using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitTreeFocus
    {
        public List<TreeFocuses> Init(List<Focus> foci)
        {
            List<TreeFocuses> trees = new List<TreeFocuses>()
            {
                new TreeFocuses()
                {
                    Id = 0,
                    Name = "Standart tree"
                }
            };
            for (int i = 0; i < foci.Count; i++)
            {
                if (i <= 24)
                {
                    trees[0].foci.Add(foci[i]);
                }
            }
            return trees;
        }
    }
}
