﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic.Classes.Game.Standart;

namespace GameLogic.Classes.Game.Uryad.Foci
{
    [Serializable]
    public class Effect
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Parametr> parametrs { get; set; }
    }
}
