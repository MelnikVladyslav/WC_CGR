﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Uryad.Foci
{
    [Serializable]
    public class TreeFocuses
    {
        public int Id;
        public string Name;
        public List<Focus> foci = new List<Focus> { };
    }
}
