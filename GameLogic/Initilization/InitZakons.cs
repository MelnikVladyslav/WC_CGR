using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Uryad.Zakonu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitZakons
    {
        public List<Zakonu> Init(List<Parametr> parametrs)
        {
            List<Zakonu> zakonus = new List<Zakonu>()
            {
                //Import\Export
                new Zakonu()
                {
                    Id = 0,
                    Name = "Відкрита економіка",
                    Description="Відкрита економіка",
                    Type = TypeZak.ImportExport,
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
                            Name = parametrs[3].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = 10
                        },
                    }
                },
                new Zakonu()
                {
                    Id = 1,
                    Name = "Закрита економіка",
                    Description="Закрита економіка",
                    Type = TypeZak.ImportExport,
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
                            Name = parametrs[3].Name,
                            Value = -10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[1].Name,
                            Value = -10
                        },
                    }
                },

                //Army
                new Zakonu()
                {
                    Id = 2,
                    Name = "Пацифізм",
                    Description="0.5% буде мобілізовано від загального населення",
                    Type = TypeZak.Prizov,
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
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[2].Name,
                            Value = -10
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[6].Name,
                            Value = 0.5f
                        },
                    }
                },
                new Zakonu()
                {
                    Id = 3,
                    Name = "Добровольці",
                    Description="1% буде мобілізовано від загального населення",
                    Type = TypeZak.Prizov,
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 300
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[2].Name,
                            Value = 0
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[6].Name,
                            Value = 1f
                        },
                    }
                },
                new Zakonu()
                {
                    Id = 4,
                    Name = "Часткова мобілізація",
                    Description="1.5% буде мобілізовано від загального населення",
                    Type = TypeZak.Prizov,
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 450
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[2].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[6].Name,
                            Value = 1.5f
                        },
                    }
                },
                new Zakonu()
                {
                    Id = 5,
                    Name = "Масштабна мобілізація",
                    Description="2% буде мобілізовано від загального населення",
                    Type = TypeZak.Prizov,
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 600
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -20
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[2].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[6].Name,
                            Value = 2f
                        },
                    }
                },
                new Zakonu()
                {
                    Id = 6,
                    Name = "Всі в армію",
                    Description="5% буде мобілізовано від загального населення",
                    Type = TypeZak.Prizov,
                    Price = new Parametr()
                    {
                        Id = 0,
                        Name = parametrs[0].Name,
                        Value = 750
                    },
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -30
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[2].Name,
                            Value = 30
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[6].Name,
                            Value = 5f
                        },
                    }
                },

                //Economic
                new Zakonu()
                {
                    Id = 7,
                    Name = "Цивільна економіка",
                    Description="Економіка працює повністю на народ країни",
                    Type = TypeZak.Economic,
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
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[3].Name,
                            Value = 10
                        },
                    }
                },
                new Zakonu()
                {
                    Id = 8,
                    Name = "Військові рейки",
                    Description="Економіка повністю переведена у військовий режим і працює на армію.",
                    Type = TypeZak.Economic,
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
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[3].Name,
                            Value = 5
                        },
                    }
                },
            };
            return zakonus;
        }
    }
}
