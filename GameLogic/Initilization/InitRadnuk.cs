using GameLogic.Classes.Game.Persons;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitRadnuk
    {
        public List<Radnuk> Init(List<Parametr> parametrs)
        {
            List<Radnuk> radnuks = new List<Radnuk>()
            {
                //Ukraine
                new Radnuk()
                {
                    Id = 0,
                    Name = "Віталій Чуркін",
                    Description = "політик, один із лідерів Руху Демократичної України, спрямованого на розвиток демократії та прав людини.",
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 150
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "популярність прозахідних",
                            Value = 0.05f
                        }
                    }
                },
                new Radnuk()
                {
                    Id = 1,
                    Name = "Степан Хмара",
                    Description = "голова Руху за самооборону, відомий своїми поглядами на український націоналізм.",
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 150
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "популярність націоналізму",
                            Value = 0.05f
                        }
                    }
                },
                new Radnuk()
                {
                    Id = 2,
                    Name = "Наталя Вітренко",
                    Description = "лідер Всеукраїнського об'єднання \"Ліва опозиція\", яка висловлювала проросійські погляди в питаннях економіки та інших сферах.",
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 150
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "популярність проросійських",
                            Value = 0.05f
                        }
                    }
                },
                new Radnuk()
                {
                    Id = 3,
                    Name = "Анатолій Гриценко",
                    Description = "начальник Головного управління міжнародної військової співпраці та безпеки Міністерства оборони України, активно долучався до розгляду питань безпеки та оборони.",
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 150
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[2].Name,
                            Value = 10
                        }
                    }
                },

                //russia
                new Radnuk()
                {
                    Id = 4,
                    Name = "Владимир Жириновський",
                    Description = "ідер Ліберально-демократичної партії Росії. Жириновський виступав за захист прав російців та національну єдність, але його підходи часто були контроверсійними.",
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 150
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "популярність націоналізму",
                            Value = 0.05f
                        }
                    }
                },
                new Radnuk()
                {
                    Id = 5,
                    Name = "Геннадій Зюганов",
                    Description = "Лідер Комуністичної партії Російської Федерації. Зюганов виступав за відновлення впливу Росії та соціалістичний розвиток країни.",
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 150
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "популярність проросійських",
                            Value = 0.05f
                        }
                    }
                },
                new Radnuk()
                {
                    Id = 6,
                    Name = "Анатолій Чубайс",
                    Description = "Політик та економіст, один із головних архітекторів економічних реформ в 1990-х. Чубайс підтримував курс на ринкову економіку та розмежування влади від економіки з метою створення стабільної країни.",
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 150
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = 10
                        }
                    }
                },
            };
            return radnuks;
        }
    }
}
