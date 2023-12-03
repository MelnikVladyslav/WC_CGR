using GameLogic.Classes.Game.Ideologies;
using GameLogic.Classes.Game.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitParty
    {
        public List<Party> Init(List<Ideology> ideologies, List<Leader> leader)
        {
            List<Party> list = new List<Party>()
            { 
                //Ukraine
                new Party()
                {
                    Id = 1,
                    Name = "Народний Рух України \"РУХ\"",
                    dateCreate = Convert.ToDateTime("01.01.1989"),
                    ideology = ideologies[0],
                    leader = leader[2]
                },
                new Party()
                {
                    Id = 2,
                    Name = "Соціал-демократична партія України",
                    dateCreate = Convert.ToDateTime("01.01.1990"),
                    ideology = ideologies[0],
                    leader = leader[3]
                },
                new Party()
                {
                    Id = 3,
                    Name = "«Європе́йська Соліда́рність»",
                    dateCreate = Convert.ToDateTime("01.01.2000"),
                    ideology = ideologies[0],
                    leader = leader[4]
                },
                new Party()
                {
                    Id = 4,
                    Name = "“Слуга народу”",
                    dateCreate = Convert.ToDateTime("01.01.2016"),
                    ideology = ideologies[0],
                    leader = leader[5]
                },
                new Party()
                {
                    Id = 5,
                    Name = "Наша Україна — Народна самооборона",
                    dateCreate = Convert.ToDateTime("01.01.2001"),
                    ideology = ideologies[0],
                    leader = leader[2]
                },
                new Party()
                {
                    Id = 6,
                    Name = "ОУН(М)",
                    dateCreate = Convert.ToDateTime("01.01.1942"),
                    ideology = ideologies[1],
                    leader = leader[7]
                },
                new Party()
                {
                    Id = 7,
                    Name = "ОУН(Б)",
                    dateCreate = Convert.ToDateTime("01.01.1942"),
                    ideology = ideologies[1],
                    leader = leader[8]
                },
                new Party()
                {
                    Id = 8,
                    Name = "НВР “Правий сектор”",
                    dateCreate = Convert.ToDateTime("28.11.1989"),
                    ideology = ideologies[1],
                    leader = leader[9]
                },
                new Party()
                {
                    Id = 9,
                    Name = "СНПУ",
                    dateCreate = Convert.ToDateTime("01.01.1991"),
                    ideology = ideologies[1],
                    leader = leader[10]
                },
                new Party()
                {
                    Id = 10,
                    Name = "комуністична партія України",
                    dateCreate = Convert.ToDateTime("01.01.1991"),
                    ideology = ideologies[2],
                    leader = leader[11]
                },
                new Party()
                {
                    Id = 11,
                    Name = "партія регіонів",
                    dateCreate = Convert.ToDateTime("01.01.1997"),
                    ideology = ideologies[2],
                    leader = leader[12]
                },
                new Party()
                {
                    Id = 12,
                    Name = "опзж",
                    dateCreate = Convert.ToDateTime("01.01.2008"),
                    ideology = ideologies[2],
                    leader = leader[13]
                },

                //russia
                new Party()
                {
                    Id = 13,
                    Name = "Демократична Росія",
                    dateCreate = Convert.ToDateTime("01.01.1990"),
                    ideology = ideologies[0],
                    leader = leader[14]
                },
                new Party()
                {
                    Id = 14,
                    Name = "ЛДПР",
                    dateCreate = Convert.ToDateTime("01.01.1991"),
                    ideology = ideologies[0],
                    leader = leader[15]
                },
                new Party()
                {
                    Id = 15,
                    Name = "Республіканська Партія СНД",
                    dateCreate = Convert.ToDateTime("01.01.1991"),
                    ideology = ideologies[0],
                    leader = leader[16]
                },
                new Party()
                {
                    Id = 16,
                    Name = "партія єльціна",
                    dateCreate = Convert.ToDateTime("01.01.1991"),
                    ideology = ideologies[2],
                    leader = leader[17]
                },
                new Party()
                {
                    Id = 17,
                    Name = "Комуністична Партія Росії",
                    dateCreate = Convert.ToDateTime("01.01.1991"),
                    ideology = ideologies[2],
                    leader = leader[18]
                },
            };
            return list;
        }
    }
}
