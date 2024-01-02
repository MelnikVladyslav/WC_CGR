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
                    Name = "Покращена гармата II",
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
                    Name = "Покращена гармата III",
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
                    Name = "Покращена гармата II",
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
                    Name = "Покращена гармата III",
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
                    Name = "Покращена гармата II",
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
                    Name = "Покращена гармата III",
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
            technologies[1].prevTech = technologies[0];
            technologies[2].prevTech = technologies[1];
            technologies[3].prevTech = technologies[2];
            technologies[4].prevTech = technologies[3];
            technologies[5].prevTech = technologies[4];
            technologies[6].prevTech = technologies[5];
            technologies[7].prevTech = technologies[6];
            technologies[9].prevTech = technologies[8];
            technologies[10].prevTech = technologies[9];
            technologies[11].prevTech = technologies[10];
            technologies[12].prevTech = technologies[11];
            technologies[13].prevTech = technologies[12];
            technologies[14].prevTech = technologies[13];
            technologies[15].prevTech = technologies[14];
            technologies[16].prevTech = technologies[15];
            technologies[18].prevTech = technologies[17];
            technologies[19].prevTech = technologies[18];
            technologies[20].prevTech = technologies[19];
            technologies[21].prevTech = technologies[20];
            technologies[22].prevTech = technologies[21];
            technologies[23].prevTech = technologies[22];
            technologies[24].prevTech = technologies[23];
            technologies[26].prevTech = technologies[25];
            technologies[27].prevTech = technologies[26];
            technologies[28].prevTech = technologies[27];
            technologies[29].prevTech = technologies[28];
            technologies[30].prevTech = technologies[29];
            technologies[31].prevTech = technologies[30];
            technologies[32].prevTech = technologies[31];
            technologies[34].prevTech = technologies[33];
            technologies[35].prevTech = technologies[34];
            technologies[36].prevTech = technologies[35];
            technologies[37].prevTech = technologies[36];
            technologies[38].prevTech = technologies[37];
            technologies[39].prevTech = technologies[38];
            technologies[40].prevTech = technologies[39];
            technologies[42].prevTech = technologies[41];
            technologies[43].prevTech = technologies[42];
            technologies[44].prevTech = technologies[43];
            technologies[45].prevTech = technologies[44];
            technologies[46].prevTech = technologies[45];
            technologies[47].prevTech = technologies[46];
            technologies[48].prevTech = technologies[47];
            technologies[50].prevTech = technologies[49];
            technologies[51].prevTech = technologies[50];
            technologies[52].prevTech = technologies[51];
            technologies[53].prevTech = technologies[52];
            technologies[54].prevTech = technologies[53];
            technologies[55].prevTech = technologies[54];
            technologies[56].prevTech = technologies[55];
            technologies[58].prevTech = technologies[57];
            technologies[59].prevTech = technologies[58];
            technologies[60].prevTech = technologies[59];
            technologies[61].prevTech = technologies[60];
            technologies[62].prevTech = technologies[61];
            technologies[63].prevTech = technologies[62];
            technologies[64].prevTech = technologies[63];
            technologies[66].prevTech = technologies[65];
            technologies[67].prevTech = technologies[66];
            technologies[68].prevTech = technologies[67];
            technologies[69].prevTech = technologies[68];
            technologies[70].prevTech = technologies[69];
            technologies[71].prevTech = technologies[70];
            technologies[72].prevTech = technologies[71];
            technologies[74].prevTech = technologies[73];
            technologies[75].prevTech = technologies[74];
            technologies[76].prevTech = technologies[75];
            technologies[77].prevTech = technologies[76];
            technologies[78].prevTech = technologies[77];
            technologies[79].prevTech = technologies[78];
            technologies[82].prevTech = technologies[81];
            technologies[83].prevTech = technologies[82];
            technologies[84].prevTech = technologies[83];
            technologies[85].prevTech = technologies[84];
            technologies[86].prevTech = technologies[85];
            technologies[88].prevTech = technologies[87];
            technologies[89].prevTech = technologies[88];
            technologies[90].prevTech = technologies[89];

            return technologies;
        }
    }
}
