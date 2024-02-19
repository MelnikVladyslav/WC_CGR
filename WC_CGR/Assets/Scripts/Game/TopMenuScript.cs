using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class TopMenuScript : MonoBehaviour
    {
        #region TopMenu
        public Text stabTopMenu;
        public Text warSupTopMenu;
        public Text politTopMenu;
        public Text recruitTopMenu;
        #endregion

        #region Details
        public Text stabTopMenuDet;
        public Text warSupTopMenuDet;
        public Text politTopMenuDet;
        public Text recruitTopMenuDet;
        public Text popTopMenuDet;
        public Text armyTopMenuDet;
        public Text vvpTopMenuDet;
        public Text kilkFabrTopMenuDet;
        public Text expTopMenuDet;
        public Text nameCount;
        #endregion

        Country player = new Country();
        Players pl;

        Load load = new Load();
        Save save = new Save();

        bool isTurn = true;
        float pop = 0;
        float kilkFab = 0;
        float inv = 0;
        float curVvpBonus = 0;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Start param
            if(PlayerPrefs.GetInt("isFinAddCap") == 0)
            {
                pl = load.LoadPlayersInfo();
                player = pl.Player;

                stabTopMenu.text = player.parametrs[1].Value.ToString();
                warSupTopMenu.text = player.parametrs[2].Value.ToString();
                politTopMenu.text = player.parametrs[0].Value.ToString();
                stabTopMenuDet.text = player.parametrs[1].Value.ToString();
                warSupTopMenuDet.text = player.parametrs[2].Value.ToString();
                politTopMenuDet.text = player.parametrs[0].Value.ToString();

                PlayerPrefs.SetInt("isFinAddCap", 1);
            }

            //Turn
            if(PlayerPrefs.GetInt("Turn") == 0)
            {
                pl = load.LoadPlayersInfo();
                player = pl.Player;
                isTurn = true;
                PlayerPrefs.SetInt("Turn", 1);
            }

            //Update param
            if (isTurn)
            {
                pop = 0;
                kilkFab = 0;
                for (int i = 0; i < player.regions.Count; i++)
                {
                    pop += player.regions[i].parametrs[0].Value;
                    kilkFab += player.regions[i].parametrs[1].Value;
                }
                if (pop != player.parametrs[5].Value)
                {
                    player.parametrs[5].Value = pop;
                }
                if (kilkFab != player.parametrs[4].Value)
                {
                    player.parametrs[4].Value = kilkFab;
                }
                float invTum = 0;
                for (int i = 0; i < player.investitions.Count; i++)
                {
                    invTum += player.investitions[i].parametrs[0].Value;
                }
                if(invTum != inv)
                {
                    inv = invTum;
                }
                float vvpB = PlayerPrefs.GetFloat("vvpBonus");
                if(vvpB != curVvpBonus)
                {
                    curVvpBonus = vvpB;
                }
                player.parametrs[3].Value = ((inv + player.bonusTech + curVvpBonus) * player.parametrs[1].Value) / (player.parametrs[5].Value + player.parametrs[4].Value);
                player.parametrs[6].Value = player.parametrs[5].Value * player.zakonus[1].parametrs[2].Value;

                nameCount.text = player.Name;
                stabTopMenu.text = player.parametrs[1].Value.ToString();
                warSupTopMenu.text = player.parametrs[2].Value.ToString();
                politTopMenu.text = player.parametrs[0].Value.ToString();
                stabTopMenuDet.text = player.parametrs[1].Value.ToString();
                warSupTopMenuDet.text = player.parametrs[2].Value.ToString();
                politTopMenuDet.text = player.parametrs[0].Value.ToString();
                recruitTopMenu.text = player.parametrs[6].Value.ToString();
                recruitTopMenuDet.text = player.parametrs[6].Value.ToString();
                popTopMenuDet.text = player.parametrs[5].Value.ToString();
                armyTopMenuDet.text = player.parametrs[7].Value.ToString();
                expTopMenuDet.text = player.parametrs[8].Value.ToString();
                kilkFabrTopMenuDet.text = player.parametrs[4].Value.ToString();
                vvpTopMenuDet.text = player.parametrs[3].Value.ToString();

                pl.Player = player;
                save.SavePlayers(pl);
                isTurn = false;
            }
        }
    }
}