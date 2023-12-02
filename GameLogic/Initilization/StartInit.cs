using GameLogic.Classes.Game.Foci;
using GameLogic.Classes.Game.Ideologies;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class StartInit
    {
        List<Parametr> parametrs = new List<Parametr>();
        List<Focus> foci = new List<Focus>();
        List<TreeFocuses> treeFoci = new List<TreeFocuses>();
        List<Ideology> ideologies = new List<Ideology>();
        StartGame startGame { get; set; }

        //Inits
        InitParam initParam = new InitParam();
        InitFoci initFoci = new InitFoci();
        InitTreeFocus initTreeFoci = new InitTreeFocus();
        InitIdeol initIdeol = new InitIdeol();

        //Save
        Save save = new Save();

        public void Start()
        {
            parametrs = initParam.Init();
            foci = initFoci.Init(parametrs);
            treeFoci = initTreeFoci.Init(foci);
            ideologies = initIdeol.Init(parametrs);
            startGame = new StartGame(parametrs, foci, treeFoci, ideologies);
            save.SaveStartGame(startGame);
        }
    }
}
