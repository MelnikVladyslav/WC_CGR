using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Army.Shablons;
using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Economic;
using GameLogic.Classes.Game.Economic.Builds;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Technolog;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Classes.Game.Uryad.Persons;
using GameLogic.Classes.Game.Uryad.Richenya;
using GameLogic.Classes.Game.Uryad.Zakonu;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections.Generic;
using System.IO;
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
        List<Zakonu> zakonus = new List<Zakonu>();
        List<Radnuk> radnuks = new List<Radnuk>();
        List<Generals> generals = new List<Generals>();
        List<Richenya> richenyas = new List<Richenya>();
        List<Investitions> investitions = new List<Investitions>();
        List<Weapon> weapons = new List<Weapon>();
        List<Build> civils = new List<Build>();
        List<ArmyBuild> armyBuilds = new List<ArmyBuild>();
        List<DefendBuild> defendBuilds = new List<DefendBuild>();
        List<Technology> technologies = new List<Technology>();
        List<Pidrozdil> batalions = new List<Pidrozdil>();
        List<Country> countries = new List<Country>();
        StartGame startGame;

        //Inits
        InitParam initParam = new InitParam();
        InitFoci initFoci = new InitFoci();
        InitTreeFocus initTreeFoci = new InitTreeFocus();
        InitZakons initZakons = new InitZakons();
        InitGenerals initGenerals = new InitGenerals();
        InitRich initRich = new InitRich();
        InitInvest initInvest = new InitInvest();
        InitWeapon initWeapon = new InitWeapon();
        InitBuilds initBuilds = new InitBuilds();
        InitTech initTech = new InitTech();
        InitBatalons initBatalons = new InitBatalons();
        InitCountries initCountries = new InitCountries();

        //Save
        Save save = new Save();

        public void Start()
        {
            parametrs = initParam.Init();
            foci = initFoci.Init(parametrs);
            treeFoci = initTreeFoci.Init(foci);
            zakonus = initZakons.Init(parametrs);
            generals = initGenerals.Init(parametrs);
            richenyas = initRich.Init(parametrs);
            investitions = initInvest.Init(parametrs);
            weapons = initWeapon.Init(parametrs);
            civils = initBuilds.InitCivil();
            armyBuilds = initBuilds.InitArmy();
            defendBuilds = initBuilds.InitDefend();
            technologies = initTech.Init(weapons, parametrs);
            batalions = initBatalons.Init(parametrs);
            countries = initCountries.Init(treeFoci, generals, richenyas, zakonus, technologies, parametrs, investitions, civils, armyBuilds, defendBuilds, batalions);
            startGame = new StartGame(parametrs, 
                                      foci, 
                                      treeFoci, 
                                      zakonus,
                                      radnuks,
                                      generals,
                                      richenyas,
                                      investitions,
                                      weapons,
                                      civils,
                                      armyBuilds,
                                      defendBuilds,
                                      technologies,
                                      batalions,
                                      countries);
            save.SaveStartGame(startGame);
        }
    }
}
