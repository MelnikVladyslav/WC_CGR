﻿using GameLogic.Classes.Game.Persons;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitLeaders
    {
        public List<Leader> Init(List<Parametr> parametrs)
        {
            List<Leader> list = new List<Leader>()
            {
                //Ukraine
                new Leader()
                {
                    Id = 0,
                    Name = "Кравчук",
                    Description = "Леоні́д Мака́рович Кравчу́к (10 січня 1934, село Великий Житин, Ровенський повіт, Волинське воєводство, Польська Республіка, нині Рівненська область, Україна — 10 травня 2022[6], Мюнхен, Німеччина[7][8]) — український політик, державний діяч, перший Президент України після відновлення нею незалежності (1991—1994), Голова Верховної Ради України та останній Голова Верховної Ради УРСР (1990—1991). Депутат Верховної ради УРСР 10–11-го скликань. Народний депутат України (1990—1991 та 1994—2006). Голова громадської організації «Українська Рада Миру», президент громадського об'єднання «Рівненське земляцтво» (2001—2022)[9], Герой України (2001), кавалер ордена Свободи (2014), повний кавалер ордена князя Ярослава Мудрого. Кандидат економічних наук. Лавреат премії «Celebrity Awards 2020» в номінації «Людина року».",
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
                new Leader()
                {
                    Id = 1,
                    Name = "Кучма",
                    Description = "Леоні́д Дани́лович Ку́чма (нар. 9 серпня 1938, с. Чайкине, Новгород-Сіверський район, Чернігівська область, Українська РСР, СРСР) — український управлінець, політик і державний діяч, другий Президент України (19 липня 1994 — 23 січня 2005), прем'єр-міністр України з 13 жовтня 1992 по 21 вересня 1993, генеральний директор ДП «Виробниче об'єднання Південний машинобудівний завод ім. О.М. Макарова» (1986—1992). Почесний громадянин Дніпра. Лауреат Державної премії в галузі науки і техніки та премії Леніна.\r\n\r\n",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[0].Name,
                            Value = 10
                        }
                    }
                },
                new Leader()
                {
                    Id = 2,
                    Name = "В'ячеслав Чорновіл",
                    Description = "В'ячесла́в Макси́мович Чорнові́л (24 грудня 1937, смт Єрки Катеринопільського р-ну, Київської області, Української СРСР нині Черкаської області — 25 березня 1999, Бориспіль, Київської області, Україна) — український політик, громадський діяч, публіцист, літературний критик, народний депутат України I—III скликань (1990—1999), діяч руху опору проти зросійщення та національної дискримінації українського народу, політичний в'язень СРСР. Провідник українського національно-демократичного визвольного руху кінця 80-х — 90-х років; другий голова Народного руху України (1992—1999). Герой України (2000, посмертно), кавалер ордена князя Ярослава Мудрого V ступеня, лауреат Міжнародної журналістської премії імені Ніколаса Томаліна (1975) та Національної премії імені Тараса Шевченка (1997).",
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
                new Leader()
                {
                    Id = 3,
                    Name = "Юрій Буздуган",
                    Description = "Народився 10 жовтня 1962 (м. Новоселиця, Чернівецька область); українець; батько Олексій Дмитрович (1939) — електромонтажник, бригадир; мати Ірина Василівна (1941) — бухгалтер; дружина Скоморощенко Олена Миколаївна (1961) — кандидат філософських наук, науковий працівник Інституту філософії НАН України.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[5].Name,
                            Value = 10
                        }
                    }
                },
                new Leader()
                {
                    Id = 4,
                    Name = "Петро Порошенко",
                    Description = "Петро́ Олексі́йович Пороше́нко (нар. 26 вересня 1965; Болград, Одеська область, Українська РСР, СРСР) — український політик та державний діяч, підприємець, п'ятий президент України (7 червня 2014 — 20 травня 2019). Народний депутат України, керівник партії «Європейська солідарність».",
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
                new Leader()
                {
                    Id = 5,
                    Name = "Володимир Зеленський",
                    Description = "Володи́мир Олекса́ндрович Зеле́нський (нар. 25 січня 1978, Кривий Ріг, Дніпропетровська область, Українська РСР, СРСР) — український державний діяч, шостий і чинний Президент України з 20 травня 2019 року[⇨]. До вступу на посаду здобув популярність як шоумен, актор, комік, режисер, продюсер і сценарист. Був співвласником і художнім керівником «Студії Квартал-95» (2003—2019) та генеральним продюсером телеканалу «Інтер» (2010—2012).",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 10
                        }
                    }
                },
                new Leader()
                {
                    Id = 6,
                    Name = "Віктор Андрійович Ющенко",
                    Description = "Ві́ктор Андрі́йович Ю́щенко (Аудіо Вимовафайл; нар. 23 лютого 1954, с. Хоружівка, Недригайлівський район, Сумська область) — український політик і державний діяч, банкір. Третій Президент України (2005—2010). Сьомий прем'єр-міністр України (1999—2001), голова партії «Наша Україна» (2005—2013)[2].",
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
                new Leader()
                {
                    Id = 7,
                    Name = "Богдан Остапович Червак",
                    Description = "Богда́н Оста́пович Черва́к (нар. 29 червня 1964, м. Дрогобич, Львівська область) — український громадський і політичний діяч. Голова Організації українських націоналістів. Перший заступник Голови Державного комітету телебачення та радіомовлення України[1].",
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
                new Leader()
                {
                    Id = 8,
                    Name = "Микола Плав'юк",
                    Description = "Мико́ла Васи́льович Плав'ю́к (англ. Mykola Vasyliovych Plaviuk; 5 червня 1925[3][4][5], с. Русів, Снятинський повіт, Станиславівське воєводство, Польща, нині Снятинський район, Івано-Франківська область, Україна — 10 березня 2012, Гамільтон, Онтаріо, Канада[6][4]) — український політичний і громадський діяч в еміграції, останній Президент УНР в екзилі (1989—1992), п'ятий Голова Організації українських націоналістів (1979—2012), визначний публіцист, співорганізатор та один з президентів СКВУ. Борець за незалежність України у ХХ сторіччі[7].",
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
                new Leader()
                {
                    Id = 9,
                    Name = "Дмитро Анатолійович Ярош",
                    Description = "Дмитро́ Анатолійович Я́рош (нар. 30 вересня 1971, Дніпродзержинськ, нині Кам'янське, Дніпропетровська область) — український громадсько-політичний діяч, військовослужбовець, колишній лідер та засновник організації «Правий сектор» (2014—2015), член-засновник організації «Тризуб», командувач Української добровольчої армії.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[2].Name,
                            Value = 20
                        }
                    }
                },
                new Leader()
                {
                    Id = 10,
                    Name = "Олег Ярославович Тягнибок",
                    Description = "Оле́г Яросла́вович Тягнибо́к (нар. 7 листопада 1968, Львів) — український політик, націоналіст, голова політичної партії Всеукраїнське об'єднання «Свобода». Народний депутат України III, IV та VII скликань (1998–2006, з 2012), кандидат на посаду Президента України на виборах 2010 та 2014 років. Старший брат Андрія Тягнибока. Майор ЗСУ[1].",
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
                new Leader()
                {
                    Id = 11,
                    Name = "симоненко петро миколайович",
                    Description = "симоненко петро миколайович (нар. 1 серпня 1952, Сталіно (нині — Донецьк, Українська РСР) — проросійський політик та колаборант з Росією, українофоб, колишній народний депутат України ІІ—VII скликання, керівник забороненої Комуністичної партії України та голова фракції партії у Верховній раді, перший секретар ЦК КПУ (з червня 1993 року). У грудні 2012 — жовтні 2014 роках — член Комітету ВРУ VII скликання з питань правової політики.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        }
                    }
                },
                new Leader()
                {
                    Id = 12,
                    Name = "віктор федорович янукович",
                    Description = "віктор федорович янукович (нар. 9 липня 1950, Єнакієве, Сталінська область, Українська РСР) — колишній український політичний та державний діяч, четвертий Президент України (2010—2014). Двічі Прем'єр-міністр України (2002—2005, 2006—2007). Двічі був кандидатом на посаду Президента України (2004, 2010). Голова Партії регіонів (2003—2010). Батько Олександра та Віктора Януковича.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        }
                    }
                },
                new Leader()
                {
                    Id = 13,
                    Name = "вадим рабінович",
                    Description = "вадим рабінович (нар. 4 серпня 1953, Харків, Українська РСР) — проросійський українсько-ізраїльський політик, громадський діяч, бізнесмен, президент холдингу RC-Group і медійної Media International Group. Був президентом футбольного клубу «Арсенал» (Київ). Організатор підпільних виробництв у часи СРСР[2]. Співголова забороненої політичної партії «Опозиційна платформа — За життя» разом з Юрієм Бойком. Кандидат в президенти України в 2014 році.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        }
                    }
                },

                //russia
                new Leader()
                {
                    Id = 14,
                    Name = "старовойтова галина василівна",
                    Description = "старовойтова галина василівна (17 травня 1946, Челябінськ, Російська РФСР — 20 листопада 1998, Санкт-Петербург, Росія) — російська політична та громадська діячка, фахівець у галузі міжнаціональних відносин, правозахисник, кандидат історичних наук[12]. Застрелена у своєму будинку.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        }
                    }
                },
                new Leader()
                {
                    Id = 15,
                    Name = "володимир вольфович жириновський",
                    Description = "володимир вольфович жириновський (рос. Владимир Вольфович Жириновский; до 1964 — Ейдельштейн; 25 квітня 1946, Алмати, Казахська РСР — 6 квітня 2022, Москва, РФ[9]) — радянський та російський політик, юрист. Засновник та голова Ліберально-демократичної партії Росії (1992—2022)[10]. Депутат Державної Думи Федерального збору Російської Федерації восьми скликань (12 грудня 1993 — 6 квітня 2022), керівник фракції ЛДПР в Держдумі (21 грудня 2011 — 6 квітня 2022). Доктор філософських наук, заслужений юрист Росії, повний кавалер ордена «За заслуги».",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        }
                    }
                },
                new Leader()
                {
                    Id = 16,
                    Name = "Республіканська Партія СНД",
                    Description = "Група республіканців",
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
                new Leader()
                {
                    Id = 17,
                    Name = "борис миколайович єльцин",
                    Description = "Бори́с Микола́йович Є́льцин (рос. Бори́с Никола́евич Е́льцин; 1 лютого 1931, Бутка, Свердловська область, Російська РФСР — 23 квітня 2007, Москва, Росія) — російський політичний та державний діяч.\r\n\r\nПрезидент Російської Федерації з 25 грудня 1991 року по 31 грудня 1999 року. Президент Російської Радянської Федеративної Соціалістичної Республіки (РРФСР) у 1991 роках.\r\n\r\nЧлен ЦК КПРС у 1981—1990 роках. Кандидат у члени Політбюро ЦК КПРС з 18 лютого 1986 по 18 лютого 1988 року. Депутат Верховної Ради СРСР 9—11-го скликань.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        }
                    }
                },
                new Leader()
                {
                    Id = 18,
                    Name = "геннадій андрійович зюганов",
                    Description = "геннадій андрійович зюганов (рос. Геннадий Андреевич Зюганов; нар. 26 червня 1944, Мимрино, Орловська область, Російська РФСР, СРСР) — російський політик, голова фракції Компартії Росії у Державній думі, перший секретар ЦК Комуністичної партії Російської Федерації. Депутат Державної думи I—VI скликань (з 1993 року), член ПАРЄ (з 1996 року). Чотири рази балотувався на пост Президента Російської Федерації (1996, 2000, 2008, 2012), щоразу займав друге місце. Доктор філософських наук.",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[1].Name,
                            Value = -10
                        }
                    }
                }
            };
            return list;
        }
    }
}