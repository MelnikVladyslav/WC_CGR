using GameLogic.Classes.Game.Economic;
using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class InitInvest
    {
        public List<Investitions> Init(List<Parametr> parametrs)
        {
            List<Investitions> investitions = new List<Investitions>()
            {
                new Investitions()
                {
                    Id = 0,
                    Name = "Малі",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 0.5f
                        }
                    }
                },
                new Investitions()
                {
                    Id = 1,
                    Name = "Середні",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 1f
                        }
                    }
                },
                new Investitions()
                {
                    Id = 2,
                    Name = "Великі",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = parametrs[3].Name,
                            Value = 1.5f
                        }
                    }
                },
            };
            return investitions;
        }
    }
}
