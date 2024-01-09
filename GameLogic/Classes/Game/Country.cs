using GameLogic.Classes.Game.Army.Shablons;
using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Economic;
using GameLogic.Classes.Game.Economic.Builds;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Technolog;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Classes.Game.Uryad.Ideologies;
using GameLogic.Classes.Game.Uryad.Persons;
using GameLogic.Classes.Game.Uryad.Richenya;
using GameLogic.Classes.Game.Uryad.Zakonu;

namespace GameLogic.Classes.Game
{
    [Serializable]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TreeFocuses treeFocuses { get; set; }
        public List<Party> parties = new List<Party>();
        public Party currentParty { get; set; }
        public Leader leader { get; set; }
        public List<string> nameAlianses = new List<string>();
        public List<Generals> generals = new List<Generals>();
        public List<Radnuk> radnuks = new List<Radnuk>();  
        public List<Richenya> richenyas = new List<Richenya>();
        public List<Zakonu> zakonus = new List<Zakonu>();
        public List<Technology> technologies = new List<Technology>();
        public List<Parametr> parametrs = new List<Parametr>();
        public List<Investitions> investitions = new List<Investitions>();
        public List<Build> builds = new List<Build>();
        public List<ArmyBuild> armyBuilds = new List<ArmyBuild>();
        public List<DefendBuild> defendBuilds = new List<DefendBuild>();
        public List<Weapon> weapons = new List<Weapon>();
        public List<Weapon> aviations = new List<Weapon>();
        public List<Pidrozdil> pidrozdils = new List<Pidrozdil>();
        public List<Rotes> shablonRotes = new List<Rotes>();
        public List<Divisions> shablonDivisions = new List<Divisions>();
        public List<Region> regions = new List<Region>();
        public Region capital { set; get; }
    }
}
