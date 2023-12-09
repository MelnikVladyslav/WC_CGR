using GameLogic.Classes.Game.Economic;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Classes.Game.Uryad.Ideologies;
using GameLogic.Classes.Game.Uryad.Persons;
using GameLogic.Classes.Game.Uryad.Richenya;
using GameLogic.Classes.Game.Uryad.Zakonu;
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
        List<Zakonu> zakonus = new List<Zakonu>();
        List<Radnuk> radnuks = new List<Radnuk>();
        List<Generals> generals = new List<Generals>();
        List<Richenya> richenyas = new List<Richenya>();
        List<Investitions> investitions = new List<Investitions>();
        StartGame startGame { get; set; }

        //Inits
        InitParam initParam = new InitParam();
        InitFoci initFoci = new InitFoci();
        InitTreeFocus initTreeFoci = new InitTreeFocus();
        InitIdeol initIdeol = new InitIdeol();
        InitLeaders initLeaders = new InitLeaders();
        InitParty initParty = new InitParty();
        InitZakons initZakons = new InitZakons();
        InitRadnuk initRadnuk = new InitRadnuk();
        InitGenerals initGenerals = new InitGenerals();
        InitRich initRich = new InitRich();
        InitInvest initInvest = new InitInvest();

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
            zakonus = initZakons.Init(parametrs);
            radnuks = initRadnuk.Init(parametrs);
            generals = initGenerals.Init(parametrs);
            richenyas = initRich.Init(parametrs);
            investitions = initInvest.Init(parametrs);
            startGame = new StartGame(parametrs, 
                                      foci, 
                                      treeFoci, 
                                      ideologies, 
                                      leaders,
                                      parties,
                                      zakonus,
                                      radnuks,
                                      generals,
                                      richenyas,
                                      investitions);
            save.SaveStartGame(startGame);
        }
    }
}
