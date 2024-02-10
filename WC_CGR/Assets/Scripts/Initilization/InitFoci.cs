using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitFoci
    {
        public List<Focus> Init(List<Parametr> par)
        {
            List<Focus> list = new List<Focus>() 
            { 
                //Standart
                //Polit
                new Focus()
                {
                    Id = 0,
                    Name = "Політичний шлях",
                    Description = "Нам потрібно обрати свій курс",
                    KilkDay = 70,
                    parametrs = new List<Parametr> 
                    { 
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 100
                        } 
                    }
                },
                //Nato
                new Focus()
                {
                    Id = 1,
                    Name = "Захід",
                    Description = "Наші західні партнери можуть стати надійними союзниками",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        }
                    }
                },
                new Focus()
                {
                    Id = 2,
                    Name = "Реформи",
                    Description = "Нам потрібно провести реформи для ліберізації влади",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        }
                    },
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Демократичні реформи",
                        Description = "Демократичні реформи",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[1].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 3,
                    Name = "ЄС",
                    Description = "ЄС - наші друзі",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = "Відпрвка заявки до ЄС"
                        }
                    }
                },
                new Focus()
                {
                    Id = 4,
                    Name = "НАТО",
                    Description = "НАТО - наші союзники",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = "Відпрвка заявки до НАТО"
                        }
                    }
                },
                //Our
                new Focus()
                {
                    Id = 5,
                    Name = "Свій шлях",
                    Description = "Наша країна для нашої нації. А не продажного заходу чи дикої Азії.",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        }
                    }
                },
                new Focus()
                {
                    Id = 6,
                    Name = "Реформи",
                    Description = "Нам потрібно провести реформи для націоналізації влади",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        }
                    },
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Націоналістичні реформи",
                        Description = "Націоналістичні реформи",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[2].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 7,
                    Name = "ЕНС",
                    Description = "Ми створимо свій економічний союз.",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = "Буде створено\\відправлено запрос на вступ до ЕНС"
                        }
                    }
                },
                new Focus()
                {
                    Id = 8,
                    Name = "АНД",
                    Description = "Ми створимо свій союз для захисту традицій і порядку в світі.",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = "Буде створено\\відправлено запрос на вступ до АНД"
                        }
                    }
                },
                //snd
                new Focus()
                {
                    Id = 9,
                    Name = "Схід",
                    Description = "Наші східні партнери можуть стати надійними союзниками",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        }
                    }
                },
                new Focus()
                {
                    Id = 10,
                    Name = "Олігархія",
                    Description = "Нам потрібно ввести олігархів для контролю влади",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        }
                    },
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Олігархія",
                        Description = "Олігархія",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[2].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 11,
                    Name = "ЄАС",
                    Description = "ЄАС - наші друзі",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = "Буде відправлено запрос на вступ до ЄАС"
                        }
                    }
                },
                new Focus()
                {
                    Id = 12,
                    Name = "СНД",
                    Description = "СНД - наші союзники",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 50
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = "Буде відправлено запрос на вступ до СНД"
                        }
                    }
                },

                //Economic
                new Focus()
                {
                    Id = 13,
                    Name = "Економічний шлях",
                    Description = "Нам потрібно обрати свій економічний курс",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 100
                        }
                    }
                },
                //Store
                new Focus()
                {
                    Id = 14,
                    Name = "Ринок",
                    Description = "Ринкова економіка збільшить конкуренцію і вибір продукту",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Ринкова економіка",
                        Description = "Ринкова економіка",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[3].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[1].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 15,
                    Name = "Збільшення інвестицій",
                    Description = "Нам потрібно збільшити інвестиції в економіку",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Ринкова економіка",
                        Description = "Ринкова економіка",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[3].Name,
                                Value = 20
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[1].Name,
                                Value = 20
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 16,
                    Name = "Послаблення корупції",
                    Description = "Нам потрібно боротися із корупцією",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Боротьба із корупцією",
                        Description = "Боротьба із корупцією",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[3].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[1].Name,
                                Value = 10
                            }
                        }
                    }
                },
                //Plan
                new Focus()
                {
                    Id = 17,
                    Name = "План",
                    Description = "Планова економіка дозволить контролювати виробництво",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Планова економіка",
                        Description = "Планова економіка",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[3].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[1].Name,
                                Value = -10
                            },
                            new Parametr()
                            {
                                Id = 2,
                                Name = par[2].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 18,
                    Name = "Збільшення будівництва",
                    Description = "Нам потрібно збільшити будівництво заводів",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Планова економіка",
                        Description = "Планова економіка",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[3].Name,
                                Value = 20
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[2].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 19,
                    Name = "Посилення корупції",
                    Description = "В корупції нічого поганого",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Корупція",
                        Description = "Корупція",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[3].Name,
                                Value = -10
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[1].Name,
                                Value = -10
                            }
                        }
                    }
                },

                //Army
                new Focus()
                {
                    Id = 20,
                    Name = "Армія",
                    Description = "Нам потрібна своя армія",
                    KilkDay = 70,
                    parametrs = new List<Parametr>
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = par[0].Name,
                            Value = 100
                        }
                    }
                },
                //Elita
                new Focus()
                {
                    Id = 21,
                    Name = "Еліта",
                    Description = "Нам потрібна елітна армія",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Елітна армія",
                        Description = "Елітна армія",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[11].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[12].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 2,
                                Name = par[13].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 3,
                                Name = par[14].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 4,
                                Name = par[9].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 22,
                    Name = "Муштрування",
                    Description = "Нам потрібна добре вимуштрувана армія",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Елітна армія",
                        Description = "Елітна армія",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[11].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[12].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 2,
                                Name = par[13].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 3,
                                Name = par[14].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 4,
                                Name = par[9].Name,
                                Value = 20
                            }
                        }
                    }
                },
                //Patriotic
                new Focus()
                {
                    Id = 23,
                    Name = "Патріотична армія",
                    Description = "Нам потрібна армія яка усвідомлює за що вона бореться.",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Патріотична армія",
                        Description = "Патріотична армія",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[11].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[12].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 2,
                                Name = par[13].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 3,
                                Name = par[14].Name,
                                Value = 10
                            },
                            new Parametr()
                            {
                                Id = 4,
                                Name = par[9].Name,
                                Value = 10
                            }
                        }
                    }
                },
                new Focus()
                {
                    Id = 24,
                    Name = "Партріотичність",
                    Description = "Нам потрібна добре вмотивована армія",
                    KilkDay = 70,
                    effect = new Effect()
                    {
                        Id = 0,
                        Name = "Патріотична армія",
                        Description = "Патріотична армія",
                        parametrs = new List<Parametr>()
                        {
                            new Parametr()
                            {
                                Id = 0,
                                Name = par[11].Name,
                                Value = 20
                            },
                            new Parametr()
                            {
                                Id = 1,
                                Name = par[12].Name,
                                Value = 20
                            },
                            new Parametr()
                            {
                                Id = 2,
                                Name = par[13].Name,
                                Value = 20
                            },
                            new Parametr()
                            {
                                Id = 3,
                                Name = par[14].Name,
                                Value = 20
                            },
                            new Parametr()
                            {
                                Id = 4,
                                Name = par[9].Name,
                                Value = 20
                            }
                        }
                    }
                },
            };

            //Підключення залежностей фокусів
            //Standart
            //Polit
            list[1].prevFoc.prevFocus = list[0];
            list[2].prevFoc.prevFocus = list[1];
            list[3].prevFoc.prevFocus = list[2];
            list[4].prevFoc.prevFocus = list[3];
            list[5].prevFoc.prevFocus = list[0];
            list[6].prevFoc.prevFocus = list[5];
            list[7].prevFoc.prevFocus = list[6];
            list[8].prevFoc.prevFocus = list[7];
            list[9].prevFoc.prevFocus = list[0];
            list[10].prevFoc.prevFocus = list[9];
            list[11].prevFoc.prevFocus = list[10];
            list[12].prevFoc.prevFocus = list[11];
            //Economic
            list[14].prevFoc.prevFocus = list[13];
            list[15].prevFoc.prevFocus = list[14];
            list[16].prevFoc.prevFocus = list[15];
            list[17].prevFoc.prevFocus = list[13];
            list[18].prevFoc.prevFocus = list[17];
            list[19].prevFoc.prevFocus = list[18];
            //Army
            list[21].prevFoc.prevFocus = list[20];
            list[22].prevFoc.prevFocus = list[21];
            list[23].prevFoc.prevFocus = list[20];
            list[24].prevFoc.prevFocus = list[23];

            return list;
        }
    }
}
