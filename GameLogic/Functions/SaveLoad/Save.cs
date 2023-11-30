using GameLogic.Classes.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Functions.SaveLoad
{
    public class Save
    {
        public string folderPathInit = "Init";
        public string urlStart = "Init/startGame.json";
        public void SaveStartGame(StartGame startGame)
        {
            // Перевірка наявності папки
            if (!Directory.Exists(folderPathInit))
            {
                // Якщо папка не існує, створіть її
                Directory.CreateDirectory(folderPathInit);
            }

            // Перетворення об'єкта у JSON-рядок
            string json = JsonConvert.SerializeObject(startGame);

            // Збереження у файл
            File.WriteAllText(urlStart, json);
        }
    }
}
