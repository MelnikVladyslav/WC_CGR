﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Standart
{
    [Serializable]
    public class Parametr
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Value { get; set; }
    }
}
