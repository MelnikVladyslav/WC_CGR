using GameLogic.Classes.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

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
            StartGame deserializedStartGame = JsonUtility.FromJson<StartGame>(jsonFromFile);

            return deserializedStartGame;
        }
    }
}
