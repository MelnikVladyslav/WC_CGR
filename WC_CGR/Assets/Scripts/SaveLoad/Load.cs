using Assets.Scripts.Class.Settings;
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
        public string urlGame = "Game/players.json";

        public StartGame LoadStartInfo()
        {
            // Зчитування JSON з файлу
            string jsonFromFile = File.ReadAllText(urlStart);

            // Перетворення JSON у об'єкт
            StartGame deserializedStartGame = JsonUtility.FromJson<StartGame>(jsonFromFile);

            return deserializedStartGame;
        }

        public Players LoadPlayersInfo()
        {
            // Зчитування JSON з файлу
            string jsonFromFile = File.ReadAllText(urlGame);

            // Перетворення JSON у об'єкт
            Players deserializedPlayers = JsonUtility.FromJson<Players>(jsonFromFile);

            return deserializedPlayers;
        }
    }
}
