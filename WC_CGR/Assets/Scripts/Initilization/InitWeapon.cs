using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitWeapon
    {
        public List<Weapon> Init(List<Parametr> parametrs)
        {
            List<Weapon> init = new List<Weapon>()
            {
                //Infantry
                new Weapon()
                {
                    Id = 0,
                    Name = "Піхотне оснащення",
                    Description = "Одяг:\r\n\r\nСтандартна бойова форма, здебільшого виготовлена зі синтетичних матеріалів та бавовни.\r\nПарадний берет чи каска для захисту голови.\r\nБойовий пояс для носіння засобів індивідуального озброєння.\r\nОзброєння:\r\n\r\nАвтоматична зброя, така як AK-47 або M16.\r\nРучні гранати, кастети, ніжі.\r\nІнше:\r\n\r\nРюкзак для переноски особистих речей та додаткового обладнання.\r\nПерсональний аптечний пакет.",
                    Type = TypeWeapon.Infantry,
                    ProductionCost = 3000,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 10
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 10
                        },
                    }
                },

                //Arty
                //Polyova
                new Weapon()
                {
                    Id = 4,
                    Name = "Польова артилерія",
                    Description = "Гаубиці в 1990 році були основною артилерійською підтримкою для багатьох армій світу. Вони зазвичай мали калібр близько 155 мм, здатність стрільби на значні відстані та використання різноманітних типів артилерійських боєприпасів. Багато з них були самохідними, що полегшувало їх розміщення на полі бою.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 200,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 25
                        },
                    }
                },
                //SAU
                new Weapon()
                {
                    Id = 8,
                    Name = "САУ",
                    Description = "На початку 1990-х САУ, такі як M109 Paladin, представляли собою важкі самохідні гармати з автоматизованим системами наведення та точності стрільби. Основною метою цих систем була підтримка піхоти та удари по ворожій артилерії. Здатність до швидкої пересуваності та добре налаштовані системи вогневої підтримки були характерними особливостями на той час.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 250,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 35
                        },
                    }
                },
                //PPO
                new Weapon()
                {
                    Id = 12,
                    Name = "ППО",
                    Description = "У цей період в основному використовувались стаціонарні та мобільні ракетні системи, такі як зенітно-ракетні комплекси (ЗРК) та протиповітряні ракетні системи (ПЗРК). Вони були оснащені радарами для виявлення та відстеження ворожих літаків.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 200,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 25
                        },
                    }
                },
                //RSZV
                new Weapon()
                {
                    Id = 16,
                    Name = "РСЗВ",
                    Description = "У 1990 році ракетно-стрілецькі війська представляли собою ключовий компонент стратегічних ядерних сил. На той час, Схід-Західний конфлікт існував, і обидві сторони прагнули до забезпечення стратегічної паритетності через розвиток і модернізацію ракетних систем. Спеціалізовані комплекси, такі як \"Сатана\" (СР-20), \"Войвода\" (СС-18) на стороні Радянського Союзу та \"Мінутемен\" на стороні США, складали основну частину арсеналу.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 400,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 65
                        },
                    }
                },

                //Techniks
                //BMP
                new Weapon()
                { 
                    Id = 20,
                    Name = "БМП",
                    Description = "На початку 1990-х років БМП-2 була однією з передових бойових машин піхоти. Вона була озброєна 30-мм автоматичним гарматним комплексом та ракетами для протитанкового боротьби. Машина забезпечувала перевезення і висадку піхоти, а також здатна була вести вогонь у русі.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 350,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 35
                        },
                    }
                },
                //BTR
                new Weapon()
                {
                    Id = 24,
                    Name = "БТР",
                    Description = "БТРи в 1990 році мали середні розміри та були оснащені базовим захистом від стрілецької зброї та гранат.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 350,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 35
                        },
                    }
                },
                //Tanks
                new Weapon()
                {
                    Id = 28,
                    Name = "Танки",
                    Description = "У 1990 році танки залишалися ключовими елементами бронетанкових військ багатьох країн. Танки цього періоду, такі як M1 Abrams (США), Leopard 2 (Німеччина), T-72 (Росія), та Challenger 2 (Велика Британія), були оснащені добре броньованими корпусами та основними гарматами калібром 120-125 мм.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 500,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 65
                        },
                    }
                },

                //Aviation
                //Fighter
                new Weapon()
                {
                    Id = 32,
                    Name = "Винищувачі",
                    Description = "Винищувач четвертого покоління, визначений високою маневреністю та швидкістю. Оснащений потужною радарною системою та різноманітними вогневими засобами.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 500,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 35
                        },
                    }
                },
                //Bombards
                new Weapon()
                {
                    Id = 36,
                    Name = "Стратегічні бомбардувальники",
                    Description = "На початку 1990-х стратегічні бомбардувальники в основному представляли собою американські та радянські моделі, такі як B-52 Stratofortress та B-1 Lancer з боку США, і Tu-95 Bear і Tu-160 Blackjack з боку Радянського Союзу. Ці літаки мали велику дальність польоту та здатність нести ядерні та стратегічні боєголовки. Зазвичай, вони використовувалися для ведення стратегічного догляду, ядерних завдань або для демонстрації сил.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 500,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 35
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 35
                        }
                    }
                }
            };
            return init;
        }
    }
}
