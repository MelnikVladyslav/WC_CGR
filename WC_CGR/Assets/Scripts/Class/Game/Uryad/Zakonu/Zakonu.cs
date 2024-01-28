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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeZak Type { get; set; }
        public Parametr Price { get; set; }
        public List<Parametr> parametrs { get; set; }
    }
}
