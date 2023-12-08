using GameLogic.Classes.Game.Persons;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitGenerals
    {
        public List<Generals> Init(List<Parametr> parametrs)
        {
            List<Generals> generals = new List<Generals>()
            {
                //Ukraine
                new Generals()
                {
                    Id = 0,
                    Name = "Григорій Марченко",
                    Description = "Переваги:\r\n\r\nВеликий досвід та військова експертиза, що виросли з часів Радянського Союзу.\r\nУчасть у реформуванні та створенні Збройних Сил України.",
                    AttackB = 2,
                    DefenceB = 2,
                    MoveB = 3,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[19].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 1,
                    Name = "Віталій Радзівіл",
                    Description = "Переваги:\r\n\r\nРозуміння стратегічних аспектів війни та оборони.\r\nДосвід роботи на різних рівнях військового командування.",
                    AttackB = 2,
                    DefenceB = 3,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[14].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 2,
                    Name = "Володимир Шкаровський",
                    Description = "Переваги:\r\n\r\nДосвід управління великими військовими округами.\r\nЗдатність до стратегічного планування.",
                    AttackB = 2,
                    DefenceB = 2,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[9].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 3,
                    Name = "Валерій Гриценко",
                    Description = "Переваги:\r\n\r\nЗначний досвід управління військовими частинами.\r\nЕксперт в області військової стратегії.",
                    AttackB = 2,
                    DefenceB = 2,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[10].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 4,
                    Name = "Валерій Маляренко",
                    Description = "Переваги:\r\n\r\nДосвід в різних галузях військової служби.\r\nЗбалансований підхід до стратегії та тактики.",
                    AttackB = 2,
                    DefenceB = 2,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[9].Name,
                            Value = 5
                        }
                    }
                },

                //russia
                new Generals()
                {
                    Id = 5,
                    Name = "Дмитро Тимофійович Язов",
                    Description = "Переваги:\r\nБагаторічний військовий досвід, включаючи участь у Другій світовій війні.\r\nЗаслужений маршал Радянського Союзу.\r\nВисокий ранг і авторитет серед військового керівництва.",
                    AttackB = 3,
                    DefenceB = 3,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.2f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 6,
                    Name = "Валентин Іванович Востротін",
                    Description = "Переваги:\r\nВеликий досвід роботи в системі внутрішніх військ.\r\nЗдатність ефективно взаємодіяти зі спеціальними підрозділами та забезпечувати внутрішню безпеку.",
                    AttackB = 2,
                    DefenceB = 3,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[14].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 7,
                    Name = "Віктор Федорович Лебедев",
                    Description = "Переваги:\r\nВисокий ранг та військовий досвід в ряді важливих посад.\r\nЗдатність до раціонального керівництва кадрами та організації військових структур.",
                    AttackB = 2,
                    DefenceB = 2,
                    MoveB = 3,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[9].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 8,
                    Name = "Михайло Спірідонович Хрулев",
                    Description = "Переваги:\r\nКомандування великим військовим округом з великою кількістю військ.\r\nВисокий ранг та досвід управління стратегічними військами.",
                    AttackB = 2,
                    DefenceB = 2,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 5
                        }
                    }
                },
                new Generals()
                {
                    Id = 9,
                    Name = "Борис Грігорьович Громов",
                    Description = "Переваги:\r\nДосвід управління великими військовими формуваннями.\r\nУчасть у важливих міжнародних військових структурах.",
                    AttackB = 2,
                    DefenceB = 2,
                    MoveB = 2,
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
                            Name = parametrs[8].Name,
                            Value = 0.5f
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[9].Name,
                            Value = 5
                        }
                    }
                },
            };
            return generals;
        }
    }
}
