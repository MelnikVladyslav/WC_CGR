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
                    Id = 1,
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
