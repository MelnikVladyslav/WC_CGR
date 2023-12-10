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
                    Name = "Оснащення 1990",
                    Description = "Одяг:\r\n\r\nСтандартна бойова форма, здебільшого виготовлена зі синтетичних матеріалів та бавовни.\r\nПарадний берет чи каска для захисту голови.\r\nБойовий пояс для носіння засобів індивідуального озброєння.\r\nОзброєння:\r\n\r\nАвтоматична зброя, така як AK-47 або M16.\r\nРучні гранати, кастети, ніжі.\r\nІнше:\r\n\r\nРюкзак для переноски особистих речей та додаткового обладнання.\r\nПерсональний аптечний пакет.",
                    Type = TypeWeapon.Infantry,
                    ProductionCost = 100,
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
                new Weapon()
                {
                    Id = 1,
                    Name = "Оснащення 2000",
                    Description = "Одяг:\r\n\r\nМодернізована бойова форма з застосуванням нових технологій та сучасних матеріалів.\r\nЗахисний елемент для шиї та тораксу.\r\nОзброєння:\r\n\r\nВдосконалені автоматичні гвинтівки, такі як M4, AK-74M.\r\nРозширений вибір гранат та інших засобів вторгнення.\r\nЗастосування тепловізорів та нічного бачення.\r\nІнше:\r\n\r\nЛегкий бронежилет для захисту від куль.\r\nСучасний обладнаний рюкзак.",
                    Type = TypeWeapon.Infantry,
                    ProductionCost = 150,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 25
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 15
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 10
                        },
                    }
                },
                new Weapon()
                {
                    Id = 2,
                    Name = "Оснащення 2010",
                    Description = "Одяг:\r\n\r\nУдосконалені та мультіфункціональні бойові форми з інтегрованими системами захисту.\r\nОзброєння:\r\n\r\nСучасні автоматичні гвинтівки, такі як M4A1, AK-74M.\r\nДодаткові системи прицілювання та оптики.\r\nРозвинені системи гранатометів.\r\nІнше:\r\n\r\nБронежилети нового покоління.\r\nВдосконалені системи комунікації та навігації.",
                    Type = TypeWeapon.Infantry,
                    ProductionCost = 200,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 30
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 20
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 20
                        },
                    }
                },
                new Weapon()
                {
                    Id = 3,
                    Name = "Оснащення 2020",
                    Description = "Одяг:\r\n\r\nАдаптивні та \"розумні\" бойові форми із вбудованими електронічними системами.\r\nОзброєння:\r\n\r\nПодальша модернізація автоматичних гвинтівок, використання більш легких та міцних матеріалів.\r\nАвтоматизовані системи керування вогнем та прицілювання.\r\nІнше:\r\n\r\nБронежилети з вбудованими датчиками та системами медичного моніторингу.\r\nЕкзоскелети для збільшення фізичних можливостей бійців.\r\nЗастосування безпілотників та розумних технологій у бойовій діяльності.",
                    Type = TypeWeapon.Infantry,
                    ProductionCost = 250,
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

                //Arty
                //Polyova
                new Weapon()
                {
                    Id = 4,
                    Name = "Польова артилерія 1990",
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
                new Weapon()
                {
                    Id = 5,
                    Name = "Польова артилерія 2000",
                    Description = "У 2000 році гаубиці стали більш точними та маневреними завдяки вдосконаленій технології та автоматизації. Також були вдосконалені системи наведення та автоматичного завантаження, що поліпшило їхню загальну ефективність на полі бою.",
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
                new Weapon()
                {
                    Id = 6,
                    Name = "Польова артилерія 2010",
                    Description = "У 2010 році гаубиці отримали подальше вдосконалення у зв'язку із розвитком прогресивних технологій. Збільшена автономія, точність та зниження часу між пострілами дозволили їм ефективніше діяти в умовах сучасного бойового середовища.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 300,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 45
                        },
                    }
                },
                new Weapon()
                {
                    Id = 7,
                    Name = "Польова артилерія 2020",
                    Description = "У 2020 році гаубиці продовжують розвиватися в напрямку покращеної мобільності, ефективності та інтеграції в мережевий бойовий простір. Вони можуть використовувати сучасні технології, такі як штучний інтелект та системи автоматизації для забезпечення точності та швидкості стрільби. Можливість швидкої деплоймента і використання різноманітних артилерійських боєприпасів робить їх надзвичайно ефективними на полі бою.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 350,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 55
                        },
                    }
                },
                //SAU
                new Weapon()
                {
                    Id = 8,
                    Name = "САУ 1990",
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
                new Weapon()
                {
                    Id = 9,
                    Name = "САУ 2000",
                    Description = "У 2000-х САУ продовжили свій розвиток, вдосконалюючи системи автоматизації, та поліпшуючи мобільність. Нові зразки, як PzH 2000, володіли високою точністю стрільби, швидкою пересуваністю та розширеними можливостями самозахисту. Також акцент був зроблений на інтеграції високоточних систем наведення.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 300,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 45
                        },
                    }
                },
                new Weapon()
                {
                    Id = 10,
                    Name = "САУ 2010",
                    Description = "У 2010-х роках САУ продовжили розвиватися в напрямку автоматизації та цифровізації. Системи управління вогнем отримали ще більше функцій, включаючи можливості автоматичного визначення цілей та координації з іншими військовими системами. Підвищилася точність стрільби та швидкість вогню.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 350,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 55
                        },
                    }
                },
                new Weapon()
                {
                    Id = 11,
                    Name = "САУ 2020",
                    Description = "На сучасному етапі розвитку САУ, як PLZ-05, використовують передові технології, включаючи системи штучного інтелекту та автономність. Ці танки оснащені високоточними системами наведення та використовують сучасні техніки обробки інформації для аналізу бойової обстановки. Зменшення екіпажу та підвищення рівня автоматизації — це характерні ознаки.",
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
                //PPO
                new Weapon()
                {
                    Id = 12,
                    Name = "ППО 1990",
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
                new Weapon()
                {
                    Id = 13,
                    Name = "ППО 2000",
                    Description = "ППО 2000-х років включає більше автоматизовані та інтегровані системи, які забезпечують кращий виявлення та слідкування цілей. Ракетні системи отримали поліпшену точність та можливості вистрілу на різні відстані та висоти.",
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
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 35
                        },
                    }
                },
                new Weapon()
                {
                    Id = 14,
                    Name = "ППО 2010",
                    Description = "ППО 2010-х років вже включає в себе передові технології, такі як лазерні системи знищення, безпілотники для виявлення цілей та більше автоматизовані системи управління. Мобільні ППО можуть швидко пересуватися для ефективного реагування на загрози.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 300,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 45
                        },
                    }
                },
                new Weapon()
                {
                    Id = 15,
                    Name = "ППО 2020",
                    Description = "ППО 2020-х років включає в себе розширені можливості виявлення, відстеження та поразки цілей. Використання штучного інтелекту дозволяє системам самостійно аналізувати ситуацію та приймати рішення. Інтеграція зенітно-ракетних систем, авіації та систем зв'язку формує єдиний простір протиповітряної оборони для ефективного управління. Системи також можуть використовувати електромагнітні засоби, щоб перешкоджати або анулювати сучасні технології атаки.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 350,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 55
                        },
                    }
                },
                //RSZV
                new Weapon()
                {
                    Id = 16,
                    Name = "РСЗВ 1990",
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
                new Weapon()
                {
                    Id = 17,
                    Name = "РСЗВ 2000",
                    Description = "У 2000 році ракетно-стрілецькі війська проходили період переоснащення та перехід до нових, більш сучасних систем. Скорочення стратегічної ядерної зброї та підписання договорів про роззброєння ставили під сумнів доцільність великих арсеналів. Ракети серії \"Тополь-М\" (СС-27) та \"Хмельницький\" (СС-25) стали елементами стратегічних сил.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 450,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 75
                        },
                    }
                },
                new Weapon()
                {
                    Id = 18,
                    Name = "РСЗВ 2010",
                    Description = "У 2010 році ракетно-стрілецькі війська продовжували модернізацію свого арсеналу. Зменшення ядерних арсеналів та акцент на точнісних ракетах робили стратегічний баланс більш гнучким та адаптованим до нових геополітичних реалій. Розвиток ракет серії \"Іскандер\" і \"Тополь-М\" відзначався збільшеною точністю та здатністю уникнення протиракетних систем.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 500,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 85
                        },
                    }
                },
                new Weapon()
                {
                    Id = 19,
                    Name = "РСЗВ 2020",
                    Description = "У 2020 році ракетно-стрілецькі війська використовують сучасні комплекси, які поєднують у собі високу точність, маневреність та здатність уникати протиракетних систем. Ракети \"Сармат\" (РС-28) та \"Іскандер-М\" належать до передового покоління, забезпечуючи надійний стратегічний потенціал. Перехід до доктрини обмеженого використання ядерної сили став актуальним у зв'язку зі змінами в глобальній політиці та різноманітністю сучасних загроз.",
                    Type = TypeWeapon.Artillery,
                    ProductionCost = 550,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 105
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 95
                        },
                    }
                },

                //Techniks
                //BMP
                new Weapon()
                { 
                    Id = 20,
                    Name = "БМП 1990",
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
                new Weapon()
                {
                    Id = 21,
                    Name = "БМП 2000",
                    Description = "У 2000-х роках BMP-3 стала модернізованою версією, вдосконаленою з огляду на бойовий потенціал та захист екіпажу. Оновлені системи керування вогнем та оптичні приціли підвищили точність стрільби. Вона залишалася ефективною як в звільненні міст, так і в зустрічі з бронетехнікою противника.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 400,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 45
                        },
                    }
                },
                new Weapon()
                {
                    Id = 22,
                    Name = "БМП 2010",
                    Description = "У 2010-х роках розроблено нові концепції БМП, такі як Kurganets-25, які використовують передові технології. Ця машина має покращений бронювальний захист, модульний підхід до озброєння та покращену мобільність.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 450,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 55
                        },
                    }
                },
                new Weapon()
                {
                    Id = 23,
                    Name = "БМП 2020",
                    Description = "В 2020-х роках деякі країни використовують сучасні бойові машини піхоти, такі як CV90, яка має вдосконалені системи автоматизації, високоточне озброєння та захист від протитанкових засобів. Машина розроблена з урахуванням сучасних бойових вимог і забезпечує ефективну інтеграцію піхоти в бойові операції.",
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
                //BTR
                new Weapon()
                {
                    Id = 24,
                    Name = "БТР 1990",
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
                new Weapon()
                {
                    Id = 25,
                    Name = "БТР 2000",
                    Description = "БТРи отримали значне покращення в захисті та мобільності. Застосування броні та нових технологій дало змогу підняти рівень безпеки для екіпажу та піхоти.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 400,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 45
                        },
                    }
                },
                new Weapon()
                {
                    Id = 26,
                    Name = "БТР 2010",
                    Description = "БТРи стали більш міцними та компактними. Застосування складних систем електроніки сприяло підвищенню ефективності та комунікацій.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 450,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 55
                        },
                    }
                },
                new Weapon()
                {
                    Id = 27,
                    Name = "БТР 2020",
                    Description = "БТРи сучасного часу використовують передові технології бронювання та композитні матеріали для максимальної захисту.",
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
                //Tanks
                new Weapon()
                {
                    Id = 28,
                    Name = "Танки 1990",
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
                new Weapon()
                {
                    Id = 29,
                    Name = "Танки 2000",
                    Description = "В 2000 році танки продовжили еволюцію в бік покращеної бронетехніки та електроніки. Нові версії танків, такі як M1A2 Abrams, Leopard 2A6, T-90 та Challenger 2, отримали покращені системи управління вогнем, а також модернізовані захисні системи.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 550,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 75
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 75
                        },
                    }
                },
                new Weapon()
                {
                    Id = 30,
                    Name = "Танки 2010",
                    Description = "У 2010 році танки вже були добре збалансованими між мобільністю, захистом та озброєнням. Танки, такі як M1A2 SEP Abrams, Leopard 2A7, Т-90М та Challenger 2 (з модернізаціями), отримали покращені системи зв'язку та системи активного захисту.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 600,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 85
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 85
                        },
                    }
                },
                new Weapon()
                {
                    Id = 31,
                    Name = "Танки 2020",
                    Description = "На початку 2020-х танки продовжили інтеграцію новітніх технологій. Танки отримали покращені системи електронної боротьби, автономного управління та збільшені можливості вогневої потужності.",
                    Type = TypeWeapon.Technics,
                    ProductionCost = 650,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 105
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 95
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 95
                        },
                    }
                },

                //Aviation
                //Fighter
                new Weapon()
                {
                    Id = 32,
                    Name = "Винищувачі 1990",
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
                new Weapon()
                {
                    Id = 33,
                    Name = "Винищувачі 2000",
                    Description = "Винищувач п'ятого покоління з високою стійкістю до перехоплення та передовим радаром. Забезпечує перевагу в повітряному бою та невидимість для радарів.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 550,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 45
                        },
                    }
                },
                new Weapon()
                {
                    Id = 34,
                    Name = "Винищувачі 2010",
                    Description = "Винищувач п'ятого покоління, що відзначається стійкістю до перехоплення, великою швидкістю та високою маневреністю.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 600,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 55
                        },
                    }
                },
                new Weapon()
                {
                    Id = 35,
                    Name = "Винищувачі 2020",
                    Description = "Мультирольовий винищувач п'ятого покоління, здатний виконувати різноманітні завдання в повітрі та на поверхні. Об'єднує передові технології та системи управління.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 650,
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
                        new Parametr()
                        {
                            Id = 5,
                            Name = parametrs[13].Name,
                            Value = 65
                        },
                    }
                },
                //Bombards
                new Weapon()
                {
                    Id = 36,
                    Name = "Стратегічні бомбардувальники 1990",
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
                },
                new Weapon()
                {
                    Id = 37,
                    Name = "Стратегічні бомбардувальники 2000",
                    Description = "У 2000 році стратегічні бомбардувальники стали представляти більш сучасні та удосконалені моделі. Наприклад, B-2 Spirit, що є невидимим для радарів і має вдосконалені системи управління. Також, радянські моделі були модернізовані, і в Україні та Росії залишалася активною експлуатація Tu-160. Стратегічні бомбардувальники залишалися ключовою складовою стратегічного стримування.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 550,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 45
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 45
                        }
                    }
                },
                new Weapon()
                {
                    Id = 38,
                    Name = "Стратегічні бомбардувальники 2010",
                    Description = "На початку 2010-х років стратегічні бомбардувальники виявили ще більше сучасних оновлень. B-2 Spirit продовжував бути основним літаком для несення ядерного зброї, а B-52 Stratofortress та B-1 Lancer пройшли модернізації для підтримки стратегічних завдань та для несення сучасної конвенційної зброї.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 600,
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[11].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 1,
                            Name = parametrs[12].Name,
                            Value = 65
                        },
                        new Parametr()
                        {
                            Id = 2,
                            Name = parametrs[14].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 3,
                            Name = parametrs[16].Name,
                            Value = 55
                        },
                        new Parametr()
                        {
                            Id = 4,
                            Name = parametrs[15].Name,
                            Value = 55
                        }
                    }
                },
                new Weapon()
                {
                    Id = 39,
                    Name = "Стратегічні бомбардувальники 2020",
                    Description = "Стратегічні бомбардувальники в 2020 році представляли сучасні підходи до військової авіації. B-2 Spirit залишався у службі, і в США розроблялися нові проекти, такі як B-21 Raider, які мали взяти на себе роль основних стратегічних бомбардувальників. Російські літаки, такі як Tu-160М та Tu-95МС, також переживали модернізацію для забезпечення їхньої актуальності на стратегічному рівні.",
                    Type = TypeWeapon.Aviations,
                    ProductionCost = 650,
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
                        }
                    }
                }
            };
            return init;
        }
    }
}
