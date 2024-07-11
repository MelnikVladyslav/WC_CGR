using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Managers
{
    public class SkladManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Players pl = new Players();
        Country player = new Country();
        bool isOpen = false;

        public Text listWeapon;

        public void Open()
        {
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        private void Update()
        {
            if (isOpen)
            {
                listWeapon.text = "";
                for (int i = 0; i < player.weaponSklad.Count; i++)
                {
                    listWeapon.text += player.weaponSklad[i].weapon.Name + ": " + player.weaponSklad[i].Kilkisty.ToString() + "\n";
                }
            }
        }
    }
}