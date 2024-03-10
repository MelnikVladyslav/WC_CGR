using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Economic;
using GameLogic.Classes.Game.Standart;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Managers
{
    public class EconomicManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Players pl = new Players();
        Country player = new Country();
        bool isOpen = false;

        #region Investions
        public Text vvpText;
        public Text smInvText;
        public Text mdInvText;
        public Text bigInvText;

        int kilkSmInv = 0;
        int kilkMedInv = 0;
        int kilkBigInv = 0;
        #endregion

        // Use this for initialization
        void Start()
        {

        }

        public void Open()
        {
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        #region Investions Methods

        public void AddSmall()
        {
            if (player.parametrs[0].Value >= 50)
            {
                player.investitions.Add(new Investitions()
                {
                    Name = "Малі",
                    parametrs = new List<Parametr>()
                {
                    new Parametr()
                    {
                        Id = 0,
                        Name = "ВВП",
                        Value = 0.5f
                    }
                }
                });
                isOpen = true;
                player.parametrs[0].Value -= 50;
            }
        }

        public void AddMedium()
        {
            if (player.parametrs[0].Value >= 100)
            {
                player.investitions.Add(new Investitions()
                {
                    Name = "Середні",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "ВВП",
                            Value = 1f
                        }
                    }
                });
                isOpen = true;
                player.parametrs[0].Value -= 100;
            }
        }

        public void AddBig()
        {
            if (player.parametrs[0].Value >= 150)
            {
                player.investitions.Add(new Investitions()
                {
                    Name = "Великі",
                    parametrs = new List<Parametr>()
                    {
                        new Parametr()
                        {
                            Id = 0,
                            Name = "ВВП",
                            Value = 1.5f
                        }
                    }
                });
                isOpen = true;
                player.parametrs[0].Value -= 150;
            }
        }

        #endregion

        // Update is called once per frame
        void Update()
        {
            if(isOpen)
            {
                kilkSmInv = 0;
                kilkMedInv = 0;
                kilkBigInv = 0;
                vvpText.text = player.parametrs[3].Value.ToString();

                //Kilk inv
                for (int i = 0; i < player.investitions.Count; i++)
                {
                    if (player.investitions[i].Name == "Малі")
                    {
                        kilkSmInv++;
                    }
                    if (player.investitions[i].Name == "Середні")
                    {
                        kilkMedInv++;
                    }
                    if (player.investitions[i].Name == "Великі")
                    {
                        kilkBigInv++;
                    }
                }
                smInvText.text = kilkSmInv.ToString();
                mdInvText.text = kilkMedInv.ToString();
                bigInvText.text = kilkBigInv.ToString();



                isOpen = false;
                pl.Player = player;
                save.SavePlayers(pl);
            }
        }
    }
}