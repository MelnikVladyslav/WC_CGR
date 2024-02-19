using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Uryad.Persons
{
    [Serializable]
    public class Person
    {
        public int Id;
        public string Name;
        public string Description;
        public int Age;
        public bool isDead = false;

    }
}
