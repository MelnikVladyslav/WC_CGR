using GameLogic.Classes.Game;
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
        //Load
        Load load = new Load();

        public List<TreeFocuses> Init()
        {
            StartGame startGame = load.LoadStartInfo();
            List<TreeFocuses> trees = new List<TreeFocuses>()
            {
                new TreeFocuses()
                {
                    Id = 0,
                    Name = "Standart tree"
                }
            };
            for (int i = 0; i < startGame.foci.Count; i++)
            {
                if (i <= 24)
                {
                    trees[0].foci.Add(startGame.foci[i]);
                }
            }
            return trees;
        }
    }
}
