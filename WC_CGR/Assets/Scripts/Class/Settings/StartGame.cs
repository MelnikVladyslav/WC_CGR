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
using System;
using System.Collections.Generic;

namespace GameLogic.Classes.Settings
{
    [Serializable]
    public class StartGame
    {
        public List<Parametr> parametrs = new List<Parametr>();
        public List<Focus> foci = new List<Focus>();
        public List<TreeFocuses> treesFoci = new List<TreeFocuses>();
        public List<Zakonu> zakonus = new List<Zakonu>();
        public List<Radnuk> radnuks = new List<Radnuk>();
        public List<Generals> generals = new List<Generals>();
        public List<Richenya> richenyas = new List<Richenya>();
        public List<Investitions> investitions = new List<Investitions>();
        public List<Weapon> weapons = new List<Weapon>();
        public List<Build> civils = new List<Build>();
        public List<ArmyBuild> armyBuilds = new List<ArmyBuild>();
        public List<DefendBuild> defendBuilds = new List<DefendBuild>();
        public List<Technology> techs = new List<Technology>();
        public List<Pidrozdil> batalions = new List<Pidrozdil>();
        public List<Country> countries = new List<Country>();

        public StartGame(List<Parametr> parametrs, 
                         List<Focus> foci, 
                         List<TreeFocuses> treeFocuses, 
                         List<Zakonu> zakonus,
                         List<Radnuk> radnuks,
                         List<Generals> generals,
                         List<Richenya> richenyas,
                         List<Investitions> investitions,
                         List<Weapon> weapons,
                         List<Build> civils,
                         List<ArmyBuild> armyBuilds,
                         List<DefendBuild> defendBuilds,
                         List<Technology> technologies,
                         List<Pidrozdil> batalions,
                         List<Country> countries)
        {
            this.parametrs = parametrs;
            this.foci = foci;
            treesFoci = treeFocuses;
            this.zakonus = zakonus;
            this.radnuks = radnuks;
            this.generals = generals;
            this.richenyas = richenyas;
            this.investitions = investitions;
            this.weapons = weapons;
            this.civils = civils;
            this.armyBuilds = armyBuilds;
            this.defendBuilds = defendBuilds;
            techs = technologies;
            this.batalions = batalions;
            this.countries = countries;
        }
    }
}
