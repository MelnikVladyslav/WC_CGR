using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Uryad.Ideologies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitIdeol
    {
        public List<Ideology> Init(List<Parametr> parametrs)
        {
            List<Ideology> ideologies = new List<Ideology>() 
            {
                new Ideology()
                {
                    Id = 0,
                    Name = "Прозахідні"
                },
                new Ideology()
                {
                    Id = 1,
                    Name = "Націоналісти"
                },
                new Ideology()
                {
                    Id = 2,
                    Name = "Проросійські"
                },
            };
            return ideologies;
        }
    }
}
