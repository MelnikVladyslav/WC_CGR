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

namespace GameLogic.Classes.Settings
{
    [Serializable]
    public class StartGame
    {
        public List<Parametr> parametrs = new List<Parametr>();
        public List<Focus> foci = new List<Focus>();
        public List<TreeFocuses> treesFoci = new List<TreeFocuses>();
        public List<Ideology> ideologies = new List<Ideology>();
        public List<Leader> leaders = new List<Leader>();
        public List<Party> parties = new List<Party>();
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
        public List<Batalions> batalions = new List<Batalions>();

        public StartGame(List<Parametr> parametrs, 
                         List<Focus> foci, 
                         List<TreeFocuses> treeFocuses, 
                         List<Ideology> ideologies,
                         List<Leader> leaders,
                         List<Party> parties, 
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
                         List<Batalions> batalions)
        {
            this.parametrs = parametrs;
            this.foci = foci;
            treesFoci = treeFocuses;
            this.ideologies = ideologies;
            this.leaders = leaders;
            this.parties = parties;
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
        }
    }
}
