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
        List<Party> parties = new List<Party>();
        StartGame startGame { get; set; }

        //Inits
        InitParam initParam = new InitParam();
        InitFoci initFoci = new InitFoci();
        InitTreeFocus initTreeFoci = new InitTreeFocus();
        InitIdeol initIdeol = new InitIdeol();
        InitLeaders initLeaders = new InitLeaders();
        InitParty initParty = new InitParty();

        //Save
        Save save = new Save();

        public void Start()
        {
            parametrs = initParam.Init();
            foci = initFoci.Init(parametrs);
            treeFoci = initTreeFoci.Init(foci);
            ideologies = initIdeol.Init(parametrs);
            leaders = initLeaders.Init(parametrs);
            parties = initParty.Init(ideologies, leaders);
            startGame = new StartGame(parametrs, foci, treeFoci, ideologies, leaders, parties);
            save.SaveStartGame(startGame);
        }
    }
}
