using GameLogic.Classes.Game.Army;
using GameLogic.Classes.Game.Army.Shablons;
using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitBatalons
    {
        public List<Pidrozdil> Init(List<Parametr> parametrs)
        {
            List<Pidrozdil> rotas = new List<Pidrozdil>()
            {
                new Pidrozdil()
                {
                    Id = 0,
                    Name = "Легка піхота",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 100
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 100
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 4
                        },
                    }
                },
                new Pidrozdil()
                {
                    Id = 1,
                    Name = "Піхота",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 100
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 100
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 4
                        },
                    }
                },
                new Pidrozdil()
                {
                    Id = 2,
                    Name = "Артилерійська рота",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 10
                        },
                        new WeaponRota()
                        {
                            weapon = "Польова артилерія",
                            Kilkisty = 10
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 4
                        },
                    }
                },
                new Pidrozdil()
                {
                    Id = 3,
                    Name = "Рота ППО",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 10
                        },
                        new WeaponRota()
                        {
                            weapon = "ППО",
                            Kilkisty = 10
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 4
                        },
                    }
                },
                new Pidrozdil()
                {
                    Id = 4,
                    Name = "Рота РСЗВ",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 10
                        },
                        new WeaponRota()
                        {
                            weapon = "РСЗВ",
                            Kilkisty = 10
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 30
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 4
                        },
                    }
                },
                new Pidrozdil()
                {
                    Id = 4,
                    Name = "Механізована піхота",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 10
                        },
                        new WeaponRota()
                        {
                            weapon = "БМП",
                            Kilkisty = 30
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 30
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 40
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 40
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 8
                        },
                    }
                },
                new Pidrozdil()
                {
                    Id = 4,
                    Name = "Броньована піхота",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 10
                        },
                        new WeaponRota()
                        {
                            weapon = "БТР",
                            Kilkisty = 30
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 30
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 40
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 30
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 40
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 8
                        },
                    }
                },
                new Pidrozdil()
                {
                    Id = 4,
                    Name = "Танклва рота",
                    weapons = new List<WeaponRota>()
                    {
                        new WeaponRota()
                        {
                            weapon = "Піхотне оснащення",
                            Kilkisty = 10
                        },
                        new WeaponRota()
                        {
                            weapon = "Танки",
                            Kilkisty = 30
                        }
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[9].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[11].Name,
                            Value = 60
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[12].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[13].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[14].Name,
                            Value = 30
                        },
                        new Parametr()
                        {
                            Id = 6,
                            Name = parametrs[15].Name,
                            Value = 40
                        },
                        new Parametr()
                        {
                            Id = 7,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 8,
                            Name = parametrs[17].Name,
                            Value = 40
                        },
                        new Parametr()
                        {
                            Id = 9,
                            Name = parametrs[19].Name,
                            Value = 8
                        },
                    }
                },
            };
            return rotas;
        }
    }
}
