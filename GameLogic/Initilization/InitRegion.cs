using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Economic.Builds;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitRegion
    {
        public List<Region> Init(List<Build> builds, List<ArmyBuild> armyBuilds, List<DefendBuild> defendBuilds, List<Parametr> parametrs)
        {
            List<Region> regions = new List<Region>()
            {
                //Austria
                new Region()
                {
                    Id = 0,
                    Name = "Бургенланд",
                    nameCity = "Айзенштадт",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 226700
                        }
                    }
                },
                new Region()
                {
                    Id = 1,
                    Name = "Верхня Австрія",
                    nameCity = "Лінц",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 135600
                        }
                    }
                },
                new Region()
                {
                    Id = 2,
                    Name = "Нижня Австрія",
                    nameCity = "Відень",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1560500
                        }
                    }
                },
                new Region()
                {
                    Id = 3,
                    Name = "Зальцбург",
                    nameCity = "Зальцбург",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 142100
                        }
                    }
                },
                new Region()
                {
                    Id = 4,
                    Name = "Штирія",
                    nameCity = "Грац",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 264000
                        }
                    }
                },
                new Region()
                {
                    Id = 5,
                    Name = "Тіроль",
                    nameCity = "Інсбрук",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 188100
                        }
                    }
                },
                new Region()
                {
                    Id = 6,
                    Name = "Форарльберг",
                    nameCity = "Брегенц",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 253400
                        }
                    }
                },
                //Belgium
                new Region()
                {
                    Id = 7,
                    Name = "Фландрія",
                    nameCity = "Гент",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 5981854
                        }
                    }
                },
                new Region()
                {
                    Id = 8,
                    Name = "Валлонія",
                    nameCity = "Шарлеруа",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 3240608
                        }
                    }
                },
                new Region()
                {
                    Id = 9,
                    Name = "Брюссель",
                    nameCity = "Брюссель",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1026302
                        }
                    }
                },
                //Lihtenchtein
                new Region()
                {
                    Id = 10,
                    Name = "Вадуц",
                    nameCity = "Вадуц",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 32849
                        }
                    }
                },
                //Luxemburg
                new Region()
                {
                    Id = 11,
                    Name = "Люксембург",
                    nameCity = "Люксембург",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 126000
                        }
                    }
                },
                //Монако
                new Region()
                {
                    Id = 12,
                    Name = "Монте-Карло",
                    nameCity = "Монте-Карло",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 56400
                        }
                    }
                },
                //Nederlands
                new Region()
                {
                    Id = 13,
                    Name = "Північна Голландія",
                    nameCity = "Амстердам",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 718000
                        }
                    }
                },
                new Region()
                {
                    Id = 14,
                    Name = "Південна Голландія",
                    nameCity = "Роттердам",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 628000
                        }
                    }
                },
                new Region()
                {
                    Id = 15,
                    Name = "Утрехт",
                    nameCity = "Утрехт",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 280000
                        }
                    }
                },
                new Region()
                {
                    Id = 16,
                    Name = "Північний Брабант",
                    nameCity = "Ейндховен",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 220000
                        }
                    }
                },
                new Region()
                {
                    Id = 17,
                    Name = "Лімбург",
                    nameCity = "Маастрихт",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 130000
                        }
                    }
                },
                new Region()
                {
                    Id = 18,
                    Name = "Зеландія",
                    nameCity = "Мідделбург",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 85000
                        }
                    }
                },
                new Region()
                {
                    Id = 19,
                    Name = "Дренте",
                    nameCity = "Ассен",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 120000
                        }
                    }
                },
                new Region()
                {
                    Id = 20,
                    Name = "Гронінген",
                    nameCity = "Гронінген",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 160000
                        }
                    }
                },
                //Germany
                new Region()
                {
                    Id = 21,
                    Name = "Баден-Вюртемберг",
                    nameCity = "Штутгарт",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1083000
                        }
                    }
                },
                new Region()
                {
                    Id = 22,
                    Name = "Баварія",
                    nameCity = "Мюнхен",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1239000
                        }
                    }
                },
                new Region()
                {
                    Id = 23,
                    Name = "Берлін",
                    nameCity = "Берлін",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 3490000
                        }
                    }
                },
                new Region()
                {
                    Id = 24,
                    Name = "Бранденбург",
                    nameCity = "Потсдам",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 904000
                        }
                    }
                },
                new Region()
                {
                    Id = 25,
                    Name = "Брауншвейг",
                    nameCity = "Брауншвейг",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 276000
                        }
                    }
                },
                new Region()
                {
                    Id = 26,
                    Name = "Гамбург",
                    nameCity = "Гамбург",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1620000
                        }
                    }
                },
                new Region()
                {
                    Id = 27,
                    Name = "Гессен",
                    nameCity = "Франкфурт-на-Майні",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 623000
                        }
                    }
                },
                new Region()
                {
                    Id = 28,
                    Name = "Мекленбург-Передня Померанія",
                    nameCity = "Штральзунд",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 222000
                        }
                    }
                },
                new Region()
                {
                    Id = 29,
                    Name = "Нижня Саксонія",
                    nameCity = "Ганновер",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 505000

                        }
                    }
                },
                new Region()
                {
                    Id = 30,
                    Name = "Північний Рейн-Вестфалія",
                    nameCity = "Дюссельдорф",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1240000
                        }
                    }
                },
                new Region()
                {
                    Id = 31,
                    Name = "Рейнланд-Пфальц",
                    nameCity = "Майнц",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 330000
                        }
                    }
                },
                new Region()
                {
                    Id = 32,
                    Name = "Саарланд",
                    nameCity = "Саарбрюкен",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 275000
                        }
                    }
                },
                new Region()
                {
                    Id = 33,
                    Name = "Саксонія",
                    nameCity = "Дрезден",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 520000
                        }
                    }
                },
                new Region()
                {
                    Id = 34,
                    Name = "Саксонія-Ангальт",
                    nameCity = "Магдебург",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 275000
                        }
                    }
                },
                new Region()
                {
                    Id = 35,
                    Name = "Тюрингія",
                    nameCity = "Ерфурт",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 200000
                        }
                    }
                },
                //France
                new Region()
                {
                    Id = 36,
                    Name = "Аквітанія",
                    nameCity = "Бордо",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2800000
                        }
                    }
                },
                new Region()
                {
                    Id = 37,
                    Name = "Альпійські Верхні Прованс",
                    nameCity = "Марсель",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1400000
                        }
                    }
                },
                new Region()
                {
                    Id = 38,
                    Name = "Атлантична Луара",
                    nameCity = "Нансі",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1500000
                        }
                    }
                },
                new Region()
                {
                    Id = 39,
                    Name = "Бретань",
                    nameCity = "Ренн",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2700000
                        }
                    }
                },
                new Region()
                {
                    Id = 40,
                    Name = "Бургундія",
                    nameCity = "Діжон",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1600000
                        }
                    }
                },
                new Region()
                {
                    Id = 41,
                    Name = "Верхня Нормандія",
                    nameCity = "Руан",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1800000
                        }
                    }
                },
                new Region()
                {
                    Id = 42,
                    Name = "Верхня Савойя",
                    nameCity = "Аннесі",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 700000
                        }
                    }
                },
                new Region()
                {
                    Id = 43,
                    Name = "Вогези",
                    nameCity = "Епіналь",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 700000
                        }
                    }
                },
                new Region()
                {
                    Id = 44,
                    Name = "Гар",
                    nameCity = "Нім",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1100000
                        }
                    }
                },
                new Region()
                {
                    Id = 45,
                    Name = "Корсика",
                    nameCity = "Аяччо",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2800000
                        }
                    }
                },
                new Region()
                {
                    Id = 46,
                    Name = "Лангедок-Руссільйон",
                    nameCity = "Монпельє",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2500000
                        }
                    }
                },
                new Region()
                {
                    Id = 47,
                    Name = "Лімож",
                    nameCity = "Лімож",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 600000
                        }
                    }
                },
                new Region()
                {
                    Id = 48,
                    Name = "Нижня Рейн",
                    nameCity = "Страсбург",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1500000
                        }
                    }
                },
                new Region()
                {
                    Id = 49,
                    Name = "Нор-Па-де-Кале",
                    nameCity = "Лілль",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2900000
                        }
                    }
                },
                new Region()
                {
                    Id = 50,
                    Name = "Овернь",
                    nameCity = "Клермон-Ферран",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1200000
                        }
                    }
                },
                new Region()
                {
                    Id = 51,
                    Name = "Пуату-Шарант",
                    nameCity = "Пуатьє",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1400000
                        }
                    }
                },
                new Region()
                {
                    Id = 52,
                    Name = "Рона-Альпи",
                    nameCity = "Ліон",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1700000
                        }
                    }
                },
                new Region()
                {
                    Id = 53,
                    Name = "Шампань-Арденни",
                    nameCity = "Реймс",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1400000
                        }
                    }
                },
                new Region()
                {
                    Id = 54,
                    Name = "Шаранта",
                    nameCity = "Ангулем",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 600000
                        }
                    }
                },
                new Region()
                {
                    Id = 55,
                    Name = "Шер",
                    nameCity = "Шартр",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 500000
                        }
                    }
                },
                new Region()
                {
                    Id = 56,
                    Name = "Франш-Конте",
                    nameCity = "Безансон",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1100000
                        }
                    }
                },
                new Region()
                {
                    Id = 57,
                    Name = "Центр",
                    nameCity = "Орлеан",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1300000
                        }
                    }
                },
                //Switzarland
                new Region()
                {
                    Id = 58,
                    Name = "Північна Швейцарія",
                    nameCity = "Берн",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 514000
                        }
                    }
                },
                new Region()
                {
                    Id = 59,
                    Name = "Західна Швейцарія",
                    nameCity = "Женева",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 244000
                        }
                    }
                },
                new Region()
                {
                    Id = 60,
                    Name = "Центральна Швейцарія",
                    nameCity = "Люцерн",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 125000
                        }
                    }
                },
                new Region()
                {
                    Id = 61,
                    Name = "Південна Швейцарія",
                    nameCity = "Кур",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 60000
                        }
                    }
                },
                //Albania
                new Region()
                {
                    Id = 62,
                    Name = "Тирана",
                    nameCity = "Тирана",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1190000
                        }
                    }
                },
                //Andorra
                new Region()
                {
                    Id = 63,
                    Name = "Андорра",
                    nameCity = "Андорра",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 65281
                        }
                    }
                },
                //Союзна Республіка Югославія
                new Region()
                {
                    Id = 64,
                    Name = "Сербія",
                    nameCity = "Белград",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 9327300
                        }
                    }
                },
                new Region()
                {
                    Id = 65,
                    Name = "Чорногорія",
                    nameCity = "Подгорица",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1301823
                        }
                    }
                },
                //Bosnia and Gercegovina
                new Region()
                {
                    Id = 66,
                    Name = "Сараєво",
                    nameCity = "Сараєво",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 865000
                        }
                    }
                },
                new Region()
                {
                    Id = 67,
                    Name = "Герцеговина-Неретва",
                    nameCity = "Мостар",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 865000
                        }
                    }
                },
                //Vatukan
                new Region()
                {
                    Id = 68,
                    Name = "Ватикан",
                    nameCity = "Ватикан",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 795
                        }
                    }
                },
                //Greece
                new Region()
                {
                    Id = 69,
                    Name = "Аттика",
                    nameCity = "Афіни",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 3221400
                        }
                    }
                },
                new Region()
                {
                    Id = 70,
                    Name = "Епір",
                    nameCity = "Іоаніна",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 362000
                        }
                    }
                },
                new Region()
                {
                    Id = 71,
                    Name = "Крит",
                    nameCity = "Іракліон",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 840000
                        }
                    }
                },
                new Region()
                {
                    Id = 72,
                    Name = "Центральна Греція",
                    nameCity = "Лариса",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 246000
                        }
                    }
                },
                new Region()
                {
                    Id = 73,
                    Name = "Македонія-Фракія",
                    nameCity = "Салоніки",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1100000
                        }
                    }
                },
                new Region()
                {
                    Id = 74,
                    Name = "Північна Егеїда",
                    nameCity = "Мітіліна",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 232000
                        }
                    }
                },
                new Region()
                {
                    Id = 75,
                    Name = "Пелопоннес",
                    nameCity = "Пірей",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1154000
                        }
                    }
                },
                new Region()
                {
                    Id = 76,
                    Name = "Східна Македонія і Фракія",
                    nameCity = "Ксанті",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 622000
                        }
                    }
                },
                new Region()
                {
                    Id = 77,
                    Name = "Західна Македонія",
                    nameCity = "Козані",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 290000
                        }
                    }
                },
                new Region()
                {
                    Id = 78,
                    Name = "Південні Егеїди",
                    nameCity = "Родос",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 125000
                        }
                    }
                },
                //Spain
                new Region()
                {
                    Id = 79,
                    Name = "Арагон",
                    nameCity = "Сарагоса",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 660200
                        }
                    }
                },
                new Region()
                {
                    Id = 80,
                    Name = "Астурія",
                    nameCity = "Ов'єдо",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 220000
                        }
                    }
                },
                new Region()
                {
                    Id = 81,
                    Name = "Балеарські острови",
                    nameCity = "Пальма-де-Майорка",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 645000
                        }
                    }
                },
                new Region()
                {
                    Id = 82,
                    Name = "Кантабрія",
                    nameCity = "Сантандера",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1100000
                        }
                    }
                },
                new Region()
                {
                    Id = 83,
                    Name = "Мадрид",
                    nameCity = "Мадрид",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 4300000
                        }
                    }
                },
                new Region()
                {
                    Id = 84,
                    Name = "Кастилія-Ла-Манча",
                    nameCity = "Толедо",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 450000
                        }
                    }
                },
                new Region()
                {
                    Id = 85,
                    Name = "Естремадура",
                    nameCity = "Мерида",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 410000
                        }
                    }
                },
                new Region()
                {
                    Id = 86,
                    Name = "Галісія",
                    nameCity = "Ла-Корунья",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 430000
                        }
                    }
                },
                new Region()
                {
                    Id = 87,
                    Name = "Валенсія",
                    nameCity = "Валенсія",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 730000
                        }
                    }
                },
                new Region()
                {
                    Id = 88,
                    Name = "Канарські острови",
                    nameCity = "Санта-Крус-де-Тенерифе",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 500000
                        }
                    }
                },
                new Region()
                {
                    Id = 89,
                    Name = "Наварра",
                    nameCity = "Памплона",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 290000
                        }
                    }
                },
                new Region()
                {
                    Id = 90,
                    Name = "Риоха",
                    nameCity = "Логроньйо",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 310000
                        }
                    }
                },
                new Region()
                {
                    Id = 91,
                    Name = "Андалусія",
                    nameCity = "Севілья",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 720000
                        }
                    }
                },
                new Region()
                {
                    Id = 92,
                    Name = "Каталонія",
                    nameCity = "Барселона",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1600000
                        }
                    }
                },
                //Italy
                new Region()
                {
                    Id = 93,
                    Name = "Венето",
                    nameCity = "Венеція",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 4927000
                        }
                    }
                },
                new Region()
                {
                    Id = 94,
                    Name = "Ломбардія",
                    nameCity = "Мілан",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 9043000
                        }
                    }
                },
                new Region()
                {
                    Id = 95,
                    Name = "Трентино-Альто-Адідже",
                    nameCity = "Тренто",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1088000
                        }
                    }
                },
                new Region()
                {
                    Id = 96,
                    Name = "Фріулі-Венеція-Джулія",
                    nameCity = "Барселона",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1215000
                        }
                    }
                },
                new Region()
                {
                    Id = 97,
                    Name = "П'ємонт",
                    nameCity = "Турин",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 4322000
                        }
                    }
                },
                new Region()
                {
                    Id = 98,
                    Name = "Лігрія",
                    nameCity = "Генуя",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1850000
                        }
                    }
                },
                new Region()
                {
                    Id = 99,
                    Name = "Тоскана",
                    nameCity = "Флоренція",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 3618000
                        }
                    }
                },
                new Region()
                {
                    Id = 100,
                    Name = "Марке",
                    nameCity = "Анкона",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1526000
                        }
                    }
                },
                new Region()
                {
                    Id = 101,
                    Name = "Лаціо",
                    nameCity = "Рим",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 5364000
                        }
                    }
                },
                new Region()
                {
                    Id = 102,
                    Name = "Кампанія",
                    nameCity = "Неаполь",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 5689000
                        }
                    }
                },
                new Region()
                {
                    Id = 103,
                    Name = "Апулія",
                    nameCity = "Барі",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 4173000
                        }
                    }
                },
                new Region()
                {
                    Id = 104,
                    Name = "Базиліката",
                    nameCity = "Потенца",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 924000
                        }
                    }
                },
                new Region()
                {
                    Id = 105,
                    Name = "Калабрія",
                    nameCity = "Катаназаро",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2003000
                        }
                    }
                },
                new Region()
                {
                    Id = 106,
                    Name = "Молізе",
                    nameCity = "Кампобассо",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 319000
                        }
                    }
                },
                new Region()
                {
                    Id = 107,
                    Name = "Сицилія",
                    nameCity = "Палермо",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 5069000
                        }
                    }
                },
                new Region()
                {
                    Id = 108,
                    Name = "Сардинія",
                    nameCity = "Кальярі",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1667000
                        }
                    }
                },
                //Macedonia
                new Region()
                {
                    Id = 109,
                    Name = "Північна Македонія",
                    nameCity = "Скоп'є",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1000000
                        }
                    }
                },
                //Malta
                new Region()
                {
                    Id = 110,
                    Name = "Мальта",
                    nameCity = "Валлетта",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 229947
                        }
                    }
                },
                //Portugal
                new Region()
                {
                    Id = 111,
                    Name = "Алентежу",
                    nameCity = "Евора",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 423000
                        }
                    }
                },
                new Region()
                {
                    Id = 112,
                    Name = "Азорські острови",
                    nameCity = "Понта-Делгада",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 238000
                        }
                    }
                },
                new Region()
                {
                    Id = 113,
                    Name = "Брага",
                    nameCity = "Брага",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 910000
                        }
                    }
                },
                new Region()
                {
                    Id = 114,
                    Name = "Віла-Реал",
                    nameCity = "Віла-Реал",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 325000
                        }
                    }
                },
                new Region()
                {
                    Id = 115,
                    Name = "Гімарайнш",
                    nameCity = "Гімарайнш",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 521000
                        }
                    }
                },
                new Region()
                {
                    Id = 116,
                    Name = "Лісабон",
                    nameCity = "Лісабон",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2821000
                        }
                    }
                },
                new Region()
                {
                    Id = 117,
                    Name = "Міньяш",
                    nameCity = "Барселуш",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 350000
                        }
                    }
                },
                new Region()
                {
                    Id = 118,
                    Name = "Порту",
                    nameCity = "Порту",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1224000
                        }
                    }
                },
                new Region()
                {
                    Id = 119,
                    Name = "Сантарен",
                    nameCity = "Сантарен",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 442000
                        }
                    }
                },
                new Region()
                {
                    Id = 120,
                    Name = "Центральний регіон",
                    nameCity = "Коїмбра",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1200000
                        }
                    }
                },
                new Region()
                {
                    Id = 121,
                    Name = "Алгавре",
                    nameCity = "Фару",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 400000
                        }
                    }
                },
                //San-marino
                new Region()
                {
                    Id = 122,
                    Name = "Сан-Марино",
                    nameCity = "Сан-Марино",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 32284
                        }
                    }
                },
                //Slovenia
                new Region()
                {
                    Id = 123,
                    Name = "Горішка",
                    nameCity = "Нова Гориця",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 104810
                        }
                    }
                },
                new Region()
                {
                    Id = 124,
                    Name = "Краньська",
                    nameCity = "Крань",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 96431
                        }
                    }
                },
                new Region()
                {
                    Id = 125,
                    Name = "Люблянська",
                    nameCity = "Любляна",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 276704
                        }
                    }
                },
                new Region()
                {
                    Id = 126,
                    Name = "Нотраньска-Крашка",
                    nameCity = "Постойна",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 28701
                        }
                    }
                },
                new Region()
                {
                    Id = 127,
                    Name = "Помурська",
                    nameCity = "Мурська Собота",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 68724
                        }
                    }
                },
                new Region()
                {
                    Id = 128,
                    Name = "Посавська",
                    nameCity = "Целє",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 107927
                        }
                    }
                },
                new Region()
                {
                    Id = 129,
                    Name = "Приморська",
                    nameCity = "Копер",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 53916
                        }
                    }
                },
                new Region()
                {
                    Id = 130,
                    Name = "Савіньска",
                    nameCity = "Севниця",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 31576
                        }
                    }
                },
                new Region()
                {
                    Id = 131,
                    Name = "Штирійська",
                    nameCity = "Марібор",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 126819
                        }
                    }
                },
                //Chorvatia
                new Region()
                {
                    Id = 132,
                    Name = "Загребська",
                    nameCity = "Загреб",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 702000
                        }
                    }
                },
                new Region()
                {
                    Id = 133,
                    Name = "Істрія",
                    nameCity = "Пула",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 57000
                        }
                    }
                },
                new Region()
                {
                    Id = 134,
                    Name = "Карловацька",
                    nameCity = "Карловаць",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 65000
                        }
                    }
                },
                new Region()
                {
                    Id = 135,
                    Name = "Лицько-Сенjska",
                    nameCity = "Госпич",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 40000
                        }
                    }
                },
                new Region()
                {
                    Id = 136,
                    Name = "Мославина",
                    nameCity = "Славонски-Брод",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 60000
                        }
                    }
                },
                new Region()
                {
                    Id = 137,
                    Name = "Північна Далмація",
                    nameCity = "Сісак",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 60000
                        }
                    }
                },
                new Region()
                {
                    Id = 138,
                    Name = "Приморсько-Горанська",
                    nameCity = "Рієка",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 176000
                        }
                    }
                },
                new Region()
                {
                    Id = 139,
                    Name = "Східна Славонія, Бараня та Західний Срем",
                    nameCity = "Осієк",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 100000
                        }
                    }
                },
                new Region()
                {
                    Id = 140,
                    Name = "Середня Далмація",
                    nameCity = "Шибеник",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 90000
                        }
                    }
                },
                new Region()
                {
                    Id = 141,
                    Name = "Задарська",
                    nameCity = "Задар",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 70000
                        }
                    }
                },
                //Great Britanya
                new Region()
                {
                    Id = 142,
                    Name = "Англія",
                    nameCity = "Лондон",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 7200000
                        }
                    }
                },
                new Region()
                {
                    Id = 143,
                    Name = "Йоркшир і Хамбер",
                    nameCity = "Лідс",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2600000
                        }
                    }
                },
                new Region()
                {
                    Id = 144,
                    Name = "Шропшир і Вустершир",
                    nameCity = "Бірмінгем",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2200000
                        }
                    }
                },
                new Region()
                {
                    Id = 145,
                    Name = "Ланкашир",
                    nameCity = "Манчестер",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 2000000
                        }
                    }
                },
                new Region()
                {
                    Id = 146,
                    Name = "Стаффордшир",
                    nameCity = "Стаффорд",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1200000
                        }
                    }
                },
                new Region()
                {
                    Id = 147,
                    Name = "Вельс",
                    nameCity = "Кардіфф",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 287000
                        }
                    }
                },
                new Region()
                {
                    Id = 148,
                    Name = "Північна Ірландія",
                    nameCity = "Белфаст",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 325000
                        }
                    }
                },
                new Region()
                {
                    Id = 149,
                    Name = "Шотландія",
                    nameCity = "Единбург",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 466000
                        }
                    }
                },
                //Danya
                new Region()
                {
                    Id = 150,
                    Name = "Зеландія",
                    nameCity = "Копенгаген",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1525000
                        }
                    }
                },
                new Region()
                {
                    Id = 151,
                    Name = "Фюн",
                    nameCity = "Оденсе",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 236000
                        }
                    }
                },
                new Region()
                {
                    Id = 152,
                    Name = "Північна Ютландія",
                    nameCity = "Ольборг",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 205000
                        }
                    }
                },
                new Region()
                {
                    Id = 153,
                    Name = "Південна Ютландія",
                    nameCity = "Вайле",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 152000
                        }
                    }
                },
                new Region()
                {
                    Id = 154,
                    Name = "Борнхольм",
                    nameCity = "Ронне",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 45000
                        }
                    }
                },
                //Estoniya
                new Region()
                {
                    Id = 155,
                    Name = "Харьюмаа",
                    nameCity = "Таллин",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 450000
                        }
                    }
                },
                new Region()
                {
                    Id = 156,
                    Name = "Тартумаа",
                    nameCity = "Тарту",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 10000
                        }
                    }
                },
                //Irland
                new Region()
                {
                    Id = 157,
                    Name = "Дублін",
                    nameCity = "Дублін",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 1500000
                        }
                    }
                },
                //Islandiya
            };
            return regions;
        }
    }
}
