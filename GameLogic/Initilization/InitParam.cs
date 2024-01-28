using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitParam
    {
        public List<Parametr> Init()
        {
            List<Parametr> list = new List<Parametr>() 
            {
                new Parametr()
                {
                    Id = 0,
                    Name = "Політична влада",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 1,
                    Name = "Стабільність",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 2,
                    Name = "Підтримка війни",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 3,
                    Name = "ВВП",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 4,
                    Name = "Кількість фабрик",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 5,
                    Name = "Населення",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 6,
                    Name = "Резерв",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 7,
                    Name = "Армія",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 8,
                    Name = "Досвід армії",
                    Value = 0
                },
                //Army parametr
                new Parametr()
                {
                    Id = 9,
                    Name = "Організація",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 10,
                    Name = "Боєздатність",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 11,
                    Name = "Протитанкова атака",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 12,
                    Name = "Протипіхотна атака",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 13,
                    Name = "Протиповітряна атака",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 14,
                    Name = "Захист",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 15,
                    Name = "Броня",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 16,
                    Name = "Ефективність",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 17,
                    Name = "Кількість військових",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 18,
                    Name = "Кількість",
                    Value = 0
                },
                new Parametr()
                {
                    Id = 19,
                    Name = "Швидкість",
                    Value = 0
                }
            };
            return list;
        }
    }
}
