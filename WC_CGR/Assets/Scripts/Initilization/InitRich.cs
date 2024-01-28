using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Uryad.Richenya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitRich
    {
        public List<Richenya> Init(List<Parametr> parametrs)
        {
            List<Richenya> richenyas = new List<Richenya>()
            {
                new Richenya()
                {
                    Id = 0,
                    Name = "Пропагування рівності",
                    Description = "Пропагування рівності, демократичних ціностей",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "Підтримка прозахідних",
                            Value = 0.05f
                        }
                    }
                },
                new Richenya()
                {
                    Id = 1,
                    Name = "Пропагування традицій",
                    Description = "Пропагування традицій нації і власну ідентичність",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "Підтримка націоналізму",
                            Value = 0.05f
                        }
                    }
                },
                new Richenya()
                {
                    Id = 2,
                    Name = "Пропагування дикості",
                    Description = "Пропагування ідей дикої татарсько-монгольської орди",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "Підтримка проросійських",
                            Value = 0.05f
                        }
                    }
                },
                new Richenya()
                {
                    Id = 3,
                    Name = "Пропагування миру",
                    Description = "Пропагування миру і стабільності",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = 0.05f
                        }
                    }
                },
                new Richenya()
                {
                    Id = 4,
                    Name = "Пропагування війни",
                    Description = "Пропагування ідей захисту своєї держави",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[2].Name,
                            Value = 0.05f
                        }
                    }
                },
            };
            return richenyas;   
        }
    }
}
