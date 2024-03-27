using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Economic;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Settings;
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
        StartGame game;
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

        #region Builds
        public GameObject regForBuildPr;
        public GameObject contentPar;
        Button[] buttons = new Button[] { };

        public GameObject civilsPanel;
        public GameObject armyPanel;
        #endregion

        // Use this for initialization
        void Start()
        {

        }

        public void Open()
        {
            isOpen = true;
            pl = load.LoadPlayersInfo();
            game = load.LoadStartInfo();
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

        #region BuildsMethods
        public void OpenCivil()
        {
            civilsPanel.gameObject.SetActive(true);
        }

        public void OpenArmy()
        {
            armyPanel.gameObject.SetActive(true);
        }

        public void Build(string name, int idReg)
        {
            for (int i = 0; i < game.civils.Count; i++)
            {
                if (game.civils[i].Name == name)
                {
                    if (player.parametrs[0].Value >= game.civils[i].Cost)
                    {
                        player.regions[idReg].builds.Add(game.civils[i]);
                        player.regions[idReg].parametrs[1].Value += 1f;
                        
                        civilsPanel.gameObject.SetActive(false);
                        player.parametrs[0].Value -= game.civils[i].Cost;
                        isOpen = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < game.armyBuilds.Count; i++)
            {
                if (game.armyBuilds[i].Name == name)
                {
                    if (player.parametrs[0].Value >= game.armyBuilds[i].Cost)
                    {
                        player.regions[idReg].armyBuilds.Add(game.armyBuilds[i]);
                        player.regions[idReg].parametrs[1].Value += 1f;
                        player.parametrs[0].Value -= game.armyBuilds[i].Cost;
                        armyPanel.gameObject.SetActive(false);
                        isOpen = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < game.defendBuilds.Count; i++)
            {
                if (game.defendBuilds[i].Name == name)
                {
                    if (player.parametrs[0].Value >= game.defendBuilds[i].Cost)
                    {
                        player.regions[idReg].defendBuilds.Add(game.defendBuilds[i]);
                        player.regions[idReg].parametrs[1].Value += 1f;
                        player.parametrs[0].Value -= game.defendBuilds[i].Cost;
                        isOpen = true;
                        break;
                    }
                }
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

                //Builds
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < player.regions.Count; i++)
                {
                    GameObject curEff = Instantiate(regForBuildPr, contentPar.transform);
                    curEff.transform.position = new Vector3(curEff.transform.position.x, curEff.transform.position.y - (2 * i), curEff.transform.position.z);
                    Text textN = curEff.GetComponentInChildren<Text>();
                    textN.text = player.regions[i].Name;
 
                    buttons = curEff.GetComponentsInChildren<Button>();
                    foreach(Button button in buttons)
                    {
                        if (button.name == "Civil")
                        {
                            button.onClick.AddListener(() => OpenCivil());
                        }
                        if (button.name == "Army")
                        {
                            button.onClick.AddListener(() => OpenArmy());
                        }
                    }

                    //Civil panel
                    buttons = civilsPanel.GetComponentsInChildren<Button>();
                    int id = i;
                    foreach(Button button in buttons)
                    {
                        if (button.name == "CivilFabr")
                        {
                            button.onClick.AddListener(() => Build("Цивільні фабрики", id));
                        }
                        if (button.name == "Inf")
                        {
                            button.onClick.AddListener(() => Build("Інфаструктура", id));
                        }
                    }

                    //ArmyPanel
                    buttons = armyPanel.GetComponentsInChildren<Button>();
                    int idArm = i;
                    foreach (Button button in buttons)
                    {
                        if (button.name == "ArmyFabr")
                        {
                            button.onClick.AddListener(() => Build("Військові заводи", idArm));
                        }
                    }
                }
                isOpen = false;

                pl.Player = player;
                save.SavePlayers(pl);
            }
        }
    }
}