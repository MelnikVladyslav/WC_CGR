using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Technolog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitTech
    {
        public List<Technology> Init(List<Weapon> weapons, List<Parametr> parametrs)
        {
            List<Technology> technologies = new List<Technology>()
            {
                //Army
                //Infantry
                new Technology()
                {
                    Id = 0,
                    Name = "Піхотне озброєння 1990",
                    Description = "Піхотне озброєння 1990",
                    IsTech = true,
                    Type = TypeTech.Army,
                    weapon = weapons[0]
                },
                new Technology()
                {
                    Id = 1,
                    Name = "Покращене піхотне оснащення",
                    Description = "Покращене піхотне оснащення",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 2,
                    Name = "Піхотне озброєння 2000",
                    Description = "Піхотне озброєння 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[1]
                },
                new Technology()
                {
                    Id = 3,
                    Name = "Покращене обмундирування",
                    Description = "Покращене обмундирування",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 4,
                    Name = "Піхотне озброєння 2010",
                    Description = "Піхотне озброєння 2010",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[2]
                },
                new Technology()
                {
                    Id = 5,
                    Name = "Покращене піхотне оснащення II",
                    Description = "Покращене піхотне оснащення II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 6,
                    Name = "Піхотне озброєння 2020",
                    Description = "Піхотне озброєння 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[3]
                },
                new Technology()
                {
                    Id = 7,
                    Name = "Покращене обмундирування II",
                    Description = "Покращене обмундирування II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },

                //Polyova arta
                new Technology()
                {
                    Id = 8,
                    Name = "Польова артилерія 1990",
                    Description = "Польова артилерія 1990",
                    IsTech = true,
                    Type = TypeTech.Army,
                    weapon = weapons[4]
                },
                new Technology()
                {
                    Id = 9,
                    Name = "Покращений калібр",
                    Description = "Покращений калібр",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 11,
                    Name = "Польова артилерія 2000",
                    Description = "Польова артилерія 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[5]
                },
                new Technology()
                {
                    Id = 12,
                    Name = "Покращена броня",
                    Description = "Покращена броня",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 13,
                    Name = "Польова артилерія 2010",
                    Description = "Польова артилерія 2010",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[6]
                },
                new Technology()
                {
                    Id = 14,
                    Name = "Покращений калібр II",
                    Description = "Покращений калібр II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 15,
                    Name = "Польова артилерія 2020",
                    Description = "Польова артилерія 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[7]
                },
                new Technology()
                {
                    Id = 16,
                    Name = "Покращена броня III",
                    Description = "Покращена броня III",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },

                //SAU
                new Technology()
                {
                    Id = 17,
                    Name = "САУ 1990",
                    Description = "САУ 1990",
                    IsTech = true,
                    Type = TypeTech.Army,
                    weapon = weapons[8]
                },
                new Technology()
                {
                    Id = 18,
                    Name = "Покращений калібр",
                    Description = "Покращений калібр",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 19,
                    Name = "САУ 2000",
                    Description = "САУ 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[9]
                },
                new Technology()
                {
                    Id = 20,
                    Name = "Покращена броня",
                    Description = "Покращена броня",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 21,
                    Name = "САУ 2010",
                    Description = "САУ 2010",
                    KilkDay = 120,
                    Type = TypeTech.Army,
                    weapon = weapons[10]
                },
                new Technology()
                {
                    Id = 22,
                    Name = "Покращений калібр II",
                    Description = "Покращений калібр II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 23,
                    Name = "САУ 2020",
                    Description = "САУ 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[11]
                },
                new Technology()
                {
                    Id = 24,
                    Name = "Покращена броня II",
                    Description = "Покращена броня II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },

                //PPO
                new Technology()
                {
                    Id = 25,
                    Name = "ППО 1990",
                    Description = "ППО 1990",
                    IsTech = true,
                    Type = TypeTech.Army,
                    weapon = weapons[12]
                },
                new Technology()
                {
                    Id = 26,
                    Name = "Покращений калібр",
                    Description = "Покращений калібр",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[13].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 27,
                    Name = "ППО 2000",
                    Description = "ППО 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[13]
                },
                new Technology()
                {
                    Id = 28,
                    Name = "Покращена броня",
                    Description = "Покращена броня",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 29,
                    Name = "ППО 2010",
                    Description = "ППО 2010",
                    KilkDay = 120,
                    Type = TypeTech.Army,
                    weapon = weapons[14]
                },
                new Technology()
                {
                    Id = 30,
                    Name = "Покращений калібр II",
                    Description = "Покращений калібр II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[13].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 31,
                    Name = "ППО 2020",
                    Description = "ППО 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[15]
                },
                new Technology()
                {
                    Id = 32,
                    Name = "Покращена броня II",
                    Description = "Покращена броня II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },

                //RSZV
                new Technology()
                {
                    Id = 33,
                    Name = "РСЗВ 1990",
                    Description = "РСЗВ 1990",
                    IsTech = true,
                    Type = TypeTech.Army,
                    weapon = weapons[16]
                },
                new Technology()
                {
                    Id = 34,
                    Name = "Покращений калібр",
                    Description = "Покращений калібр",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 35,
                    Name = "РСЗВ 2000",
                    Description = "РСЗВ 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[17]
                },
                new Technology()
                {
                    Id = 36,
                    Name = "Покращена броня",
                    Description = "Покращена броня",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 37,
                    Name = "РСЗВ 2010",
                    Description = "РСЗВ 2010",
                    KilkDay = 120,
                    Type = TypeTech.Army,
                    weapon = weapons[18]
                },
                new Technology()
                {
                    Id = 38,
                    Name = "Покращений калібр II",
                    Description = "Покращений калібр II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        }
                    }
                },
                new Technology()
                {
                    Id = 39,
                    Name = "РСЗВ 2020",
                    Description = "РСЗВ 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[19]
                },
                new Technology()
                {
                    Id = 40,
                    Name = "Покращена броня II",
                    Description = "Покращена броня II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[14].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[15].Name,
                            Value = 7
                        }
                    }
                },

                //BMP
                new Technology()
                {
                    Id = 41,
                    Name = "БМП 1990",
                    Description = "БМП 1990",
                    Type = TypeTech.Army,
                    IsTech = true,
                    weapon = weapons[20]
                },
                new Technology()
                {
                    Id = 42,
                    Name = "Покращений двигун бмп",
                    Description = "Покращений двигун",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[19].Name,
                            Value = 5
                        },
                    }
                },
                new Technology()
                {
                    Id = 43,
                    Name = "БМП 2000",
                    Description = "БМП 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[21]
                },
                new Technology()
                {
                    Id = 44,
                    Name = "Покращена гармата бмп",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },
                new Technology()
                {
                    Id = 45,
                    Name = "БМП 2010",
                    Description = "БМП 2010",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[22]
                },
                new Technology()
                {
                    Id = 46,
                    Name = "Покращена гармата бмп II",
                    Description = "Покращена гармата II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },
                new Technology()
                {
                    Id = 47,
                    Name = "БМП 2020",
                    Description = "БМП 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[23]
                },
                new Technology()
                {
                    Id = 48,
                    Name = "Покращена гармата бмп III",
                    Description = "Покращена гармата III",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },

                //BTR
                new Technology()
                {
                    Id = 49,
                    Name = "БТР 1990",
                    Description = "БТР 1990",
                    Type = TypeTech.Army,
                    IsTech = true,
                    weapon = weapons[24]
                },
                new Technology()
                {
                    Id = 50,
                    Name = "Покращений двигун бтр",
                    Description = "Покращений двигун",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[19].Name,
                            Value = 5
                        },
                    }
                },
                new Technology()
                {
                    Id = 51,
                    Name = "БТР 2000",
                    Description = "БТР 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[25]
                },
                new Technology()
                {
                    Id = 52,
                    Name = "Покращена гармата бтр",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },
                new Technology()
                {
                    Id = 53,
                    Name = "БТР 2010",
                    Description = "БТР 2010",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[26]
                },
                new Technology()
                {
                    Id = 54,
                    Name = "Покращена гармата бтр II",
                    Description = "Покращена гармата II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },
                new Technology()
                {
                    Id = 55,
                    Name = "БТР 2020",
                    Description = "БТР 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[27]
                },
                new Technology()
                {
                    Id = 56,
                    Name = "Покращена гармата бтр III",
                    Description = "Покращена гармата III",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },

                //Tanks
                new Technology()
                {
                    Id = 57,
                    Name = "Танки 1990",
                    Description = "Танки 1990",
                    Type = TypeTech.Army,
                    IsTech = true,
                    weapon = weapons[28]
                },
                new Technology()
                {
                    Id = 58,
                    Name = "Покращений двигун танка",
                    Description = "Покращений двигун",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[19].Name,
                            Value = 5
                        },
                    }
                },
                new Technology()
                {
                    Id = 59,
                    Name = "Танки 2000",
                    Description = "Танки 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[29]
                },
                new Technology()
                {
                    Id = 60,
                    Name = "Покращена гармата танка",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },
                new Technology()
                {
                    Id = 61,
                    Name = "Танки 2010",
                    Description = "Танки 2010",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[30]
                },
                new Technology()
                {
                    Id = 62,
                    Name = "Покращена гармата танка II",
                    Description = "Покращена гармата II",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },
                new Technology()
                {
                    Id = 63,
                    Name = "Танки 2020",
                    Description = "Танки 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[31]
                },
                new Technology()
                {
                    Id = 64,
                    Name = "Покращена гармата танка III",
                    Description = "Покращена гармата III",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 7
                        },
                    }
                },

                //Fighter
                new Technology()
                {
                    Id = 65,
                    Name = "Винищувачі 1990",
                    Description = "Винищувачі 1990",
                    Type = TypeTech.Army,
                    IsTech = true,
                    weapon = weapons[32]
                },
                new Technology()
                {
                    Id = 66,
                    Name = "Покращений двигун",
                    Description = "Покращений двигун",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[19].Name,
                            Value = 5
                        },
                    }
                },
                new Technology()
                {
                    Id = 67,
                    Name = "Винищувачі 2000",
                    Description = "Винищувачі 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[33]
                },
                new Technology()
                {
                    Id = 68,
                    Name = "Покращена гармата",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[13].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 69,
                    Name = "Винищувачі 2010",
                    Description = "Винищувачі 2010",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[34]
                },
                new Technology()
                {
                    Id = 70,
                    Name = "Покращена гармата",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[13].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 71,
                    Name = "Винищувачі 2020",
                    Description = "Винищувачі 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[35]
                },
                new Technology()
                {
                    Id = 72,
                    Name = "Покращена гармата",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[13].Name,
                            Value = 5
                        }
                    }
                },

                //Bombards
                new Technology()
                {
                    Id = 73,
                    Name = "Стратегічні бомбардувальники 1990",
                    Description = "Стратегічні бомбардувальники 1990",
                    Type = TypeTech.Army,
                    IsTech = true,
                    weapon = weapons[36]
                },
                new Technology()
                {
                    Id = 74,
                    Name = "Покращений двигун",
                    Description = "Покращений двигун",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[19].Name,
                            Value = 5
                        },
                    }
                },
                new Technology()
                {
                    Id = 75,
                    Name = "Стратегічні бомбардувальники 2000",
                    Description = "Стратегічні бомбардувальники 2000",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[37]
                },
                new Technology()
                {
                    Id = 76,
                    Name = "Покращена гармата",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 77,
                    Name = "Стратегічні бомбардувальники 2010",
                    Description = "Стратегічні бомбардувальники 2010",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[38]
                },
                new Technology()
                {
                    Id = 78,
                    Name = "Покращена гармата",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 79,
                    Name = "Стратегічні бомбардувальники 2020",
                    Description = "Стратегічні бомбардувальники 2020",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    weapon = weapons[39]
                },
                new Technology()
                {
                    Id = 80,
                    Name = "Покращена гармата",
                    Description = "Покращена гармата",
                    Type = TypeTech.Army,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 5
                        }
                    }
                },


                //Economic
                new Technology()
                {
                    Id = 81,
                    Name = "Нові станки",
                    Description = "Нові станки",
                    Type = TypeTech.Economic,
                    IsTech = true,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 82,
                    Name = "Перші роботи",
                    Description = "Перші роботи",
                    Type = TypeTech.Economic,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 83,
                    Name = "Нові типи роботів",
                    Description = "Нові типи роботів",
                    Type = TypeTech.Economic,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 84,
                    Name = "Покращені умови праці",
                    Description = "Покращені умови праці",
                    Type = TypeTech.Economic,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 85,
                    Name = "Штучний інтелект",
                    Description = "Штучний інтелект",
                    Type = TypeTech.Economic,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 86,
                    Name = "Покращений AI",
                    Description = "Покращений AI",
                    Type = TypeTech.Economic,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 5
                        }
                    }
                },

                //Tech
                new Technology()
                {
                    Id = 87,
                    Name = "Перші ПК",
                    Description = "Перші ПК",
                    Type = TypeTech.Tech,
                    IsTech = true,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "бонус до вивчення технологій",
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 88,
                    Name = "ПК 2000",
                    Description = "ПК 2000",
                    Type = TypeTech.Tech,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "бонус до вивчення технологій",
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 89,
                    Name = "ПК 2010",
                    Description = "ПК 2010",
                    Type = TypeTech.Tech,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "бонус до вивчення технологій",
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 90,
                    Name = "ПК 2020",
                    Description = "ПК 2020",
                    Type = TypeTech.Tech,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "бонус до вивчення технологій",
                            Value = 5
                        }
                    }
                },
                new Technology()
                {
                    Id = 91,
                    Name = "GPT-4",
                    Description = "GPT-4",
                    Type = TypeTech.Tech,
                    KilkDay = 120,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "бонус до вивчення технологій",
                            Value = 5
                        }
                    }
                },
            };

            //Підключення залежностей технологій
            for (int i = 1; i < technologies.Count; i++)
            {
                if (i < 80)
                {
                    technologies[i].prevTech.prevTech = technologies[i - 1];
                }
                if (i > 81 && i <= 86)
                {
                    technologies[i].prevTech.prevTech = technologies[i - 1];
                }
                if (i > 87 && i <= 91)
                {
                    technologies[i].prevTech.prevTech = technologies[i - 1];
                }
            }

            return technologies;
        }
    }
}
