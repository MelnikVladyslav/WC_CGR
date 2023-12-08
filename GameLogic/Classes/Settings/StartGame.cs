using GameLogic.Classes.Game.Foci;
using GameLogic.Classes.Game.Ideologies;
using GameLogic.Classes.Game.Persons;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Zakonu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public StartGame(List<Parametr> parametrs, 
                         List<Focus> foci, 
                         List<TreeFocuses> treeFocuses, 
                         List<Ideology> ideologies,
                         List<Leader> leaders,
                         List<Party> parties, 
                         List<Zakonu> zakonus,
                         List<Radnuk> radnuks,
                         List<Generals> generals)
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
        }
    }
}
