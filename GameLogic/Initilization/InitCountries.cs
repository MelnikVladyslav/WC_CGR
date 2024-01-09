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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitCountries
    {
        public List<Country> Init(List<TreeFocuses> treeFocuses, 
                                  List<Generals> generals,
                                  List<Richenya> richenyas,
                                  List<Zakonu> zakonus,
                                  List<Technology> technologies,
                                  List<Parametr> parametrs,
                                  List<Investitions> investitions,
                                  List<Build> builds,
                                  List<ArmyBuild> armyBuilds,
                                  List<DefendBuild> defendBuilds,
                                  List<Pidrozdil> vzvods)
        {
            List<Country> countries = new List<Country>() 
            {
                new Country()
                {
                    Id = 0,
                    Name = "Австрія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 1,
                    Name = "Бельгія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 2,
                    Name = "Ліхтенштейн",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 3,
                    Name = "Люксембург",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 4,
                    Name = "Монако",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 5,
                    Name = "Нідерланди",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 6,
                    Name = "Німеччина",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 7,
                    Name = "Франція",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 8,
                    Name = "Швейцарія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 9,
                    Name = "Албанія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 10,
                    Name = "Андорра",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 11,
                    Name = "Боснія і Герцеговина",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 12,
                    Name = "Ватикан",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 13,
                    Name = "Греція",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 14,
                    Name = "Іспанія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 15,
                    Name = "Італія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 16,
                    Name = "Північна Македонія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 17,
                    Name = "Мальта",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 18,
                    Name = "Португалія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 19,
                    Name = "Сан-Марино",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 20,
                    Name = "Югославія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 21,
                    Name = "Словенія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 22,
                    Name = "Хорватія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 23,
                    Name = "Велика Британія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 24,
                    Name = "Данія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 25,
                    Name = "Естонія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 26,
                    Name = "Ірландія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 27,
                    Name = "Ісландія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 28,
                    Name = "Латвія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 29,
                    Name = "Литва",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 30,
                    Name = "Норвегія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 31,
                    Name = "Фінляндія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 32,
                    Name = "Швеція",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 33,
                    Name = "Білорусь",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 34,
                    Name = "Болгарія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 35,
                    Name = "Молдова",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 36,
                    Name = "Польща",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 37,
                    Name = "Румунія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 38,
                    Name = "Словаччина",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 39,
                    Name = "угорщина",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 40,
                    Name = "Україна",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 41,
                    Name = "Чехія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 42,
                    Name = "Азербайджан",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 43,
                    Name = "Грузія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 44,
                    Name = "Казахстан",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 45,
                    Name = "росія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 46,
                    Name = "Туреччина",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 47,
                    Name = "Вірменія",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
                new Country()
                {
                    Id = 48,
                    Name = "Кіпр",
                    treeFocuses = treeFocuses[0],
                    richenyas = richenyas,
                    zakonus = new List<Zakonu>()
                    {
                        zakonus[0],
                        zakonus[2],
                        zakonus[7],
                    },
                    technologies = technologies,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[3].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[4].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[5].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[6].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[7].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[8].Name,
                            Value = 50
                        },
                    },
                    investitions = new List<Investitions>()
                    {
                        investitions[1]
                    },
                    pidrozdils = vzvods
                },
            };
            List<string> names = new List<string>
        {
            "Alice", "Bob", "Charlie", "David", "Eva", "Frank", "Grace", "Harry", "Ivy", "Jack"
        };
            Random random = new Random();

            //Generals
            for (int i = 0; i < countries.Count; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int randIndex = random.Next(0, names.Count);
                    countries[i].generals.Add(new Generals()
                    {
                        Name = names[randIndex],
                        AttackB = random.Next(1, 5),
                        DefenceB = random.Next(1, 5),
                        MoveB = random.Next(1, 5),
                        Price = new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 100
                        }
                    });
                }
            }
            countries[40].generals = new List<Generals>();
            countries[45].generals = new List<Generals>();
            for (int i = 0; i < 5; i++)
            {
                countries[40].generals.Add(generals[i]);
            }
            for (int i = 4; i < generals.Count; i++)
            {
                countries[45].generals.Add(generals[i]);
            }

            //Radnuks
            for (int i = 0; i < countries.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int randIndex = random.Next(0, names.Count);
                    int rand = random.Next(0, 3);
                    countries[i].radnuks.Add(new Radnuk()
                    {
                        Name = names[randIndex],
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = parametrs[rand].Name,
                                Value = 10
                            }
                        },
                        Price = new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 150
                        }
                    });
                }
            }

            //Builds
            for (int i = 0; i < countries.Count; i++)
            {
                countries[i].buildsOpen = builds;
                countries[i].armyBuildsOpen = armyBuilds;
                countries[i].defendBuildsOpen = defendBuilds;
            }

            //Weapon
            for (int i = 0; i < countries.Count; i++)
            {
                for (int j = 0; j < technologies.Count; j++)
                {
                    if (technologies[j].IsTech == true)
                    {
                        if (technologies[j].weapon != null)
                        {
                            countries[i].weapons.Add(technologies[j].weapon);
                        }
                    }
                }
            }

            return countries;
        }
    }
}
