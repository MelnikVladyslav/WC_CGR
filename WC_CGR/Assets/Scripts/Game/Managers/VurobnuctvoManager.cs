using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Managers
{
    public class VurobnuctvoManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Players pl = new Players();
        Country player = new Country();
        bool isOpen = false;

        public GameObject ProductionPref;
        public GameObject contentPar;

        List<Weapon> weaponsOpen = new List<Weapon>();


        Text[] texts = new Text[] { };
        Text nameReg;
        Text kilkFabr;
        Text nameWeap;
        Text prodCost;
        Text kilkInDay;
        Dropdown weaponsDrop;

        // Use this for initialization
        void Start()
        {
            
        }

        public void Open()
        {
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
            weaponsOpen = player.weapons;
            foreach (var item in player.aviations)
            {
                weaponsOpen.Add(item);
            }
        }

        public void ChangedValues(int i)
        {
            nameReg.text = player.regions[i].Name;
            kilkFabr.text = "Кількість заводів: " + player.regions[i].armyBuilds.Count.ToString();
            kilkInDay.text = "Виробляється в хід: " + (Mathf.RoundToInt(weaponsOpen[weaponsDrop.value].ProductionCost * player.regions[i].armyBuilds.Count / 2.7f)).ToString();
            nameWeap.text = weaponsOpen[weaponsDrop.value].Name;
            prodCost.text = weaponsOpen[weaponsDrop.value].ProductionCost.ToString();

            player.regions[i].currentWeapProd = weaponsOpen[weaponsDrop.value];

            pl.Player = player;
            save.SavePlayers(pl);
        }

        // Update is called once per frame
        void Update()
        {
            if(isOpen)
            {
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < player.regions.Count; i++)
                {
                    if (player.regions[i].armyBuilds.Count > 0)
                    {
                        GameObject curProd = Instantiate(ProductionPref, contentPar.transform);
                        curProd.transform.position = new Vector3(curProd.transform.position.x, curProd.transform.position.y - (2 * i), curProd.transform.position.z);

                        texts = curProd.GetComponentsInChildren<Text>();
                        foreach (Text item in texts)
                        {
                            if(item.name == "nameReg")
                            {
                                nameReg = item;
                            }
                            if (item.name == "kilkZav")
                            {
                                kilkFabr = item;
                            }
                            if (item.name == "nameWeapon")
                            {
                                nameWeap = item;
                            }
                            if (item.name == "ProdCost")
                            {
                                prodCost = item;
                            }
                            if (item.name == "KilkInDay")
                            {
                                kilkInDay = item;
                            }
                        }
                        weaponsDrop = curProd.GetComponentInChildren<Dropdown>();

                        List<string> countOptNames = new List<string>();
                        foreach (var item in weaponsOpen)
                        {
                            countOptNames.Add(item.Name);
                        }

                        weaponsDrop.AddOptions(countOptNames);

                        int id = i;
                        weaponsDrop.onValueChanged.AddListener(delegate
                        {
                            ChangedValues(id);
                        });

                        if (player.regions[i].currentWeapProd != null)
                        {
                            for (int j = 0; j < weaponsDrop.options.Count; j++)
                            {
                                if (weaponsDrop.options[j].text == player.regions[i].currentWeapProd.Name)
                                {
                                    weaponsDrop.value = j;
                                    break;
                                }
                            }
                        }
                        nameReg.text = player.regions[i].Name;
                        kilkFabr.text = "Кількість заводів: " + player.regions[i].armyBuilds.Count.ToString();
                        kilkInDay.text = "Виробляється в хід: " + (Mathf.RoundToInt(weaponsOpen[weaponsDrop.value].ProductionCost * player.regions[i].armyBuilds.Count / 2.7f)).ToString();
                        nameWeap.text = weaponsOpen[weaponsDrop.value].Name;
                        prodCost.text = weaponsOpen[weaponsDrop.value].ProductionCost.ToString();

                    }
                }

                isOpen = false;
            }
        }
    }
}