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

namespace GameLogic.Classes.Game
{
    [Serializable]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TreeFocuses treeFocuses { get; set; }
        public List<string> nameAlianses = new List<string>();
        public List<Generals> generals = new List<Generals>();
        public List<Radnuk> radnuks = new List<Radnuk>();  
        public List<Richenya> richenyas = new List<Richenya>();
        public List<Zakonu> zakonus = new List<Zakonu>();
        public List<Technology> technologies = new List<Technology>();
        public List<Parametr> parametrs = new List<Parametr>();
        public List<Investitions> investitions = new List<Investitions>();
        public List<Build> buildsOpen = new List<Build>();
        public List<ArmyBuild> armyBuildsOpen = new List<ArmyBuild>();
        public List<DefendBuild> defendBuildsOpen = new List<DefendBuild>();
        public List<Weapon> weapons = new List<Weapon>();
        public List<Weapon> aviations = new List<Weapon>();
        public List<Pidrozdil> pidrozdils = new List<Pidrozdil>();
        public List<Rotes> shablonRotes = new List<Rotes>();
        public List<Divisions> shablonDivisions = new List<Divisions>();
        public List<Region> regions = new List<Region>();
        public Region capital { set; get; }
    }
}
