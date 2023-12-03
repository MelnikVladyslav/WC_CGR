using GameLogic.Classes.Game.Foci;
using GameLogic.Classes.Game.Ideologies;
using GameLogic.Classes.Game.Persons;
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
        List<Leader> leaders = new List<Leader>();
        StartGame startGame { get; set; }

        //Inits
        InitParam initParam = new InitParam();
        InitFoci initFoci = new InitFoci();
        InitTreeFocus initTreeFoci = new InitTreeFocus();
        InitIdeol initIdeol = new InitIdeol();
        InitLeaders initLeaders = new InitLeaders();

        //Save
        Save save = new Save();

        public void Start()
        {
            parametrs = initParam.Init();
            foci = initFoci.Init(parametrs);
            treeFoci = initTreeFoci.Init(foci);
            ideologies = initIdeol.Init(parametrs);
            leaders = initLeaders.Init(parametrs);
            startGame = new StartGame(parametrs, foci, treeFoci, ideologies, leaders);
            save.SaveStartGame(startGame);
        }
    }
}
