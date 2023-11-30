using GameLogic.Classes.Game;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Initilization
{
    public class StartInit
    {
        List<Parametr> parametrs = new List<Parametr>();
        StartGame startGame { get; set; }

        //Inits
        InitParam initParam = new InitParam();

        //Save
        Save save = new Save();

        public void Start()
        {
            parametrs = initParam.Init();
            startGame = new StartGame(parametrs);
            save.SaveStartGame(startGame);
        }
    }
}
