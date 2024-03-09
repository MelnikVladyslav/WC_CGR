using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Game.Technolog;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class TurnManager : MonoBehaviour
    {
        int day = 1, mounth = 1, year = 1992;
        DateTime date;
        int kilkDayInTurn = 10;
        float curStab = 0;
        float curWarSup = 0;
        float politSup = 0;
        float vvpBonus = 0;

        Load load = new Load();
        Save save = new Save();
        Players pl = new Players();
        Country player = new Country();

        public Text textDate;

        float stabaRich = 0;
        float warSupRich = 0;

        // Use this for initialization
        void Start()
        {
            date = new DateTime(year, mounth, day);
            textDate.text = date.ToString();
        }

        public void NextTurn()
        {
            day += kilkDayInTurn;

            if (day >= 30)
            {
                day -= 30;
                mounth++;
            }
            else if (mounth >= 12)
            {
                mounth = 1;
                year++;
            }

            date = new DateTime(year, mounth, day);
            textDate.text = date.ToString();

            pl = load.LoadPlayersInfo();
            player = pl.Player;

            float stabaNew = 50;
            curStab = player.parametrs[1].Value;
            float warSupNew = 50;
            curWarSup = player.parametrs[2].Value;
            politSup = player.parametrs[0].Value + 20 + (player.parametrs[1].Value / 10);

            //Effects
            if (player.effects.Count > 0)
            {
                for (int i = 0; i < player.effects.Count; i++)
                {
                    for (int j = 0; j < player.effects[i].parametrs.Count; j++)
                    {
                        //Staba with effects
                        if (player.parametrs[1].Name == player.effects[i].parametrs[j].Name)
                        {
                            stabaNew += player.effects[i].parametrs[j].Value;
                        }
                        //War sup with effects
                        if (player.parametrs[2].Name == player.effects[i].parametrs[j].Name)
                        {
                            warSupNew += player.effects[i].parametrs[j].Value;
                        }
                        //Vvp with effects
                        if (player.parametrs[3].Name == player.effects[i].parametrs[j].Name)
                        {
                            vvpBonus += player.effects[i].parametrs[j].Value;
                        }
                    }
                }
            }
            //Radnuks
            if (player.radnuks.Count > 0)
            {
                for (int i = 0; i < player.radnuks.Count; i++)
                {
                    for (int j = 0; j < player.radnuks[i].parametrs.Count; j++)
                    {
                        //Staba with radnuks
                        if (player.parametrs[1].Name == player.radnuks[i].parametrs[j].Name)
                        {
                            stabaNew += player.radnuks[i].parametrs[j].Value;
                        }
                        //War sup with radnuks
                        if (player.parametrs[2].Name == player.radnuks[i].parametrs[j].Name)
                        {
                            warSupNew += player.radnuks[i].parametrs[j].Value;
                        }
                        //Polit with radnuks
                        if (player.parametrs[0].Name == player.radnuks[i].parametrs[j].Name)
                        {
                            politSup += player.radnuks[i].parametrs[j].Value;
                        }
                    }
                }
            }
            //Zakonu
            if (player.zakonus.Count > 0)
            {
                for (int i = 0; i < player.zakonus.Count; i++)
                {
                    for (int j = 0; j < player.zakonus[i].parametrs.Count; j++)
                    {
                        //Staba with zakonus
                        if (player.parametrs[1].Name == player.zakonus[i].parametrs[j].Name)
                        {
                            stabaNew += player.zakonus[i].parametrs[j].Value;
                        }
                        //War sup with zakonus
                        if (player.parametrs[2].Name == player.zakonus[i].parametrs[j].Name)
                        {
                            warSupNew += player.zakonus[i].parametrs[j].Value;
                        }
                        //Vvp with zakonus
                        if (player.parametrs[3].Name == player.zakonus[i].parametrs[j].Name)
                        {
                            vvpBonus += player.zakonus[i].parametrs[j].Value;
                        }
                    }
                }
            }
            PlayerPrefs.SetFloat("vvpBonus", vvpBonus);
            vvpBonus = 0;

            //Richenyas
            int kilkDRS = PlayerPrefs.GetInt("kilkDayRichStab");
            int kilkDRW = PlayerPrefs.GetInt("kilkDayRichWar");
            if (kilkDRS != 0)
            {
                stabaRich += (0.05f * ((200 - kilkDRS) / kilkDayInTurn));
                kilkDRS -= 10;
                PlayerPrefs.SetInt("kilkDayRichStab", kilkDRS);
            }
            if (kilkDRW != 0)
            {
                warSupRich += (0.05f * ((200 - kilkDRW) / kilkDayInTurn));
                kilkDRW -= 10;
                PlayerPrefs.SetInt("kilkDayRichWar", kilkDRW);
            }

            //Final values parametres
            //Staba
            if (stabaNew > 100)
            {
                stabaNew = 100;
            }
            if(curStab != stabaNew + stabaRich)
            {
                curStab = stabaNew + stabaRich;
                player.parametrs[1].Value = curStab;
            }
            //War sup
            if (warSupNew > 100)
            {
                warSupNew = 100;
            }
            if (curWarSup != warSupNew  + warSupRich)
            {
                curWarSup = warSupNew + warSupRich;
                player.parametrs[2].Value = curWarSup;
            }
            //Polit
            player.parametrs[0].Value = politSup;

            //Focus
            if(player.currentFocus.Name != "")
            {
                if (player.currentFocus.KilkDay != player.currentFocus.KilkDayRemained)
                {
                    player.currentFocus.KilkDayRemained += kilkDayInTurn;
                }
                if (player.currentFocus.KilkDay == player.currentFocus.KilkDayRemained)
                {
                    for (int i = 0; i < player.treeFocuses.foci.Count; i++)
                    {
                        if (player.treeFocuses.foci[i].Name == player.currentFocus.Name)
                        {
                            player.treeFocuses.foci[i].isFoc = true;
                            for (int j = 0; j < player.treeFocuses.foci.Count; j++)
                            {
                                if (player.treeFocuses.foci[j].prevFoc.prevFocus.Name == player.treeFocuses.foci[i].Name)
                                {
                                    player.treeFocuses.foci[j].prevFoc.prevFocus.isFoc = true;
                                }
                            }

                            for (int a = 0; a < player.parametrs.Count; a++)
                            {
                                for (int b = 0; b < player.currentFocus.parametrs.Count; b++)
                                {
                                    if (player.parametrs[a].Name == player.currentFocus.parametrs[b].Name)
                                    {
                                        player.parametrs[a].Value += player.currentFocus.parametrs[b].Value;
                                    }
                                }
                            }
                            if(player.currentFocus.effect.Name != "")
                            {
                                player.effects.Add(player.currentFocus.effect);
                            }

                            player.currentFocus = new Focus();
                        }
                    }
                    //Political or
                    if (player.treeFocuses.foci[1].isFoc == true)
                    {
                        player.treeFocuses.foci[5].isDost = false;
                        player.treeFocuses.foci[9].isDost = false;
                    }
                    if (player.treeFocuses.foci[5].isFoc == true)
                    {
                        player.treeFocuses.foci[1].isDost = false;
                        player.treeFocuses.foci[9].isDost = false;
                    }
                    if (player.treeFocuses.foci[9].isFoc == true)
                    {
                        player.treeFocuses.foci[5].isDost = false;
                        player.treeFocuses.foci[1].isDost = false;
                    }
                    //Economic or
                    if (player.treeFocuses.foci[14].isFoc == true)
                    {
                        player.treeFocuses.foci[17].isDost = false;
                    }
                    if (player.treeFocuses.foci[17].isFoc == true)
                    {
                        player.treeFocuses.foci[14].isDost = false;
                    }
                    //Army or
                    if (player.treeFocuses.foci[21].isFoc == true)
                    {
                        player.treeFocuses.foci[23].isDost = false;
                    }
                    if (player.treeFocuses.foci[23].isFoc == true)
                    {
                        player.treeFocuses.foci[21].isDost = false;
                    }
                }
            }

            //Technology
            if (player.currentTech.Name != "")
            {
                if (player.currentTech.KilkDay != player.currentTech.KilkDayRemained)
                {
                    player.currentTech.KilkDayRemained += kilkDayInTurn;
                }
                if (player.currentTech.KilkDay <= player.currentTech.KilkDayRemained)
                {
                    for (int i = 0; i < player.technologies.Count; i++)
                    {
                        if (player.technologies[i].Name == player.currentTech.Name)
                        {
                            player.technologies[i].IsTech = true;
                            for (int j = 0; j < player.technologies.Count; j++)
                            {
                                if (player.technologies[j].prevTech.prevTech.Name == player.technologies[i].Name)
                                {
                                    player.technologies[j].prevTech.prevTech.IsTech = true;
                                }
                            }

                            for (int a = 0; a < player.weapons.Count; a++)
                            {
                                for (int c = 0; c < player.weapons[a].parametrs.Count; c++)
                                {
                                    for (int b = 0; b < player.currentTech.parametrs.Count; b++)
                                    {
                                        if (player.weapons[a].parametrs[c].Name == player.currentTech.parametrs[b].Name)
                                        {
                                            player.weapons[a].parametrs[c].Value += player.currentTech.parametrs[b].Value;
                                        }
                                    }
                                }
                            }

                            for (int a = 0; a < player.parametrs.Count; a++)
                            {
                                for (int b = 0; b < player.currentTech.parametrs.Count; b++)
                                {
                                    if (player.parametrs[a].Name == player.currentTech.parametrs[b].Name)
                                    {
                                        player.parametrs[a].Value += player.currentTech.parametrs[b].Value;
                                    }
                                    if (player.currentTech.weapon.Name != "")
                                    {
                                        player.weapons.Add(player.currentTech.weapon);
                                    }
                                }
                            }

                            player.currentTech = new Technology();
                        }
                    }
                }
                if (player.currentTech.Type == TypeTech.Tech)
                {
                    for (int c = 0; c < player.technologies.Count; c++)
                    {
                        player.technologies[c].KilkDay -= 5;
                    }
                }
            }

            pl.Player = player;
            save.SavePlayers(pl);

            PlayerPrefs.SetInt("Turn", 0);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}