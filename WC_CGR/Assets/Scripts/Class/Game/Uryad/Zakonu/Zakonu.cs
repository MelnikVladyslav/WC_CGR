using GameLogic.Classes.Game.Standart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Classes.Game.Uryad.Zakonu
{
    public enum TypeZak
    {
        ImportExport = 0,
        Prizov,
        Economic
    }

    [Serializable]
    public class Zakonu
    {
        public int Id;
        public string Name;
        public string Description;
        public TypeZak Type;
        public Parametr Price;
        public List<Parametr> parametrs = new List<Parametr>();
    }
}
