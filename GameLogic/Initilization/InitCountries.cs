using GameLogic.Classes.Game;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitCountries
    {
        public List<Country> Init(List<TreeFocuses> treeFocuses, 
                                  List<Party> parties, 
                                  List<Generals> generals,
                                  List<Radnuk> radnuks,
                                  List<Richenya> richenyas,
                                  List<Zakonu> zakonus,
                                  List<Technology> technologies,
                                  List<Parametr> parametrs,
                                  List<Investitions> investitions,
                                  List<Build> builds,
                                  List<ArmyBuild> armyBuilds,
                                  List<DefendBuild> defendBuilds,
                                  List<Weapon> weapons,
                                  List<Batalions> batalions)
        {
            List<Country> countries = new List<Country>();
            return countries;
        }
    }
}
