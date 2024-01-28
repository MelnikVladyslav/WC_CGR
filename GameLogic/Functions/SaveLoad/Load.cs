using GameLogic.Classes.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Functions.SaveLoad
{
    public class Load
    {
        public string urlStart = "Init/startGame.json";

        public StartGame LoadStartInfo()
        {
            // Зчитування JSON з файлу
            string jsonFromFile = File.ReadAllText(urlStart);

            // Перетворення JSON у об'єкт
            StartGame deserializedStartGame = JsonConvert.DeserializeObject<StartGame>(jsonFromFile);

            return deserializedStartGame;
        }
    }
}
