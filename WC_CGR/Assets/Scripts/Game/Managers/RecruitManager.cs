using Assets.Scripts.Class.Game;
using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Army.Shablons;
using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Standart;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Managers
{
    public class RecruitManager : MonoBehaviour
    {
        public List<Texture> textures = new List<Texture>();
        int currId = 0;

        Load load = new Load();
        Save save = new Save();

        Players pl = new Players();
        Country player = new Country();
        StartGame game;
        bool isOpen = false;

        #region Rota

        public GameObject viddilsPref;
        public GameObject contentVid;
        public Text txtNameRota;
        public GameObject createRota;
        public Text txtInfoRota;
        public Text txtListViddils;
        public Text txtListRotas;

        Text txtVidName;
        Button btnEnterVid;

        public Text txtViddilsName;
        public GameObject addVid;
        public GameObject panelViddls;
        public GameObject shRotes;
        int maxKilkViddils = 20;

        Rotes tempRota = new Rotes();
        #endregion

        #region Division

        public GameObject contentRot;
        public Text txtNameDiv;
        public GameObject createDiv;
        public Text txtInfoDiv;

        Text txtRotName;
        Button btnEnterRot;

        public Text txtRotsName;
        public GameObject addRota;
        public GameObject panelRotts;
        public GameObject shDivs;
        int maxKilkRot = 20;

        Divisions tempDiv = new Divisions();
        #endregion

        #region Recruit

        public GameObject contentReg;
        public GameObject prefReg;
        private Text nameReg;
        private Button recruitBut;

        public GameObject panelDiv;

        public GameObject contentRec;
        public GameObject prefRec;
        private Text nameDivRec;
        private Text timeDivRec;
        Text[] textsRec = new Text[] { };
        private Button recruitDivBut;

        int idReg = 0;

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
            game = load.LoadStartInfo();
        }

        // Update is called once per frame
        void Update()
        {
            if (isOpen)
            {
                tempRota = new Rotes();
                tempDiv = new Divisions();
                txtListRotas.text = " ";
                txtListViddils.text = " ";

                #region Viddils

                foreach(Transform child in contentVid.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < game.batalions.Count; i++)
                {
                    GameObject curProd = Instantiate(viddilsPref, contentVid.transform);
                    curProd.transform.position = new Vector3(curProd.transform.position.x, curProd.transform.position.y - (2 * i), curProd.transform.position.z);

                    int id = i;

                    txtVidName = curProd.GetComponentInChildren<Text>();
                    txtVidName.text = game.batalions[i].Name;
                    btnEnterVid = curProd.GetComponentInChildren<Button>();
                    btnEnterVid.onClick.AddListener(() => EnterViddil(id));
                }

                #endregion

                #region Rotes

                foreach (Transform child in contentRot.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < player.shablonRotes.Count; i++)
                {
                    GameObject curRot = Instantiate(viddilsPref, contentRot.transform);
                    curRot.transform.position = new Vector3(curRot.transform.position.x, curRot.transform.position.y - (2 * i), curRot.transform.position.z);

                    int id = i;

                    txtRotName = curRot.GetComponentInChildren<Text>();
                    txtRotName.text = player.shablonRotes[i].Name;
                    btnEnterRot = curRot.GetComponentInChildren<Button>();
                    btnEnterRot.onClick.AddListener(() => EnterRota(id));
                }

                #endregion

                #region Recruit

                foreach (Transform child in contentReg.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < player.regions.Count; i++)
                {
                    GameObject curReg = Instantiate(prefReg, contentReg.transform);
                    curReg.transform.position = new Vector3(curReg.transform.position.x, curReg.transform.position.y - (2 * i), curReg.transform.position.z);

                    int id = i;

                    nameReg = curReg.GetComponentInChildren<Text>();
                    nameReg.text = player.regions[i].Name;
                    recruitBut = curReg.GetComponentInChildren<Button>();
                    recruitBut.onClick.AddListener(() => OpenDivision(id));
                }

                foreach (Transform child in contentRec.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < player.shablonDivisions.Count; i++)
                {
                    GameObject curRec = Instantiate(prefRec, contentRec.transform);
                    curRec.transform.position = new Vector3(curRec.transform.position.x, curRec.transform.position.y - (2 * i), curRec.transform.position.z);

                    textsRec = curRec.GetComponentsInChildren<Text>();
                    foreach (var item in textsRec)
                    {
                        if (item.name == "nameDiv")
                        {
                            nameDivRec = item;
                            nameDivRec.text = player.shablonDivisions[i].Name;
                        }
                        if (item.name == "timeCreate")
                        {
                            timeDivRec = item;
                            timeDivRec.text = "Time recruit: 10";
                        }
                    }

                    int id = i;

                    recruitDivBut = curRec.GetComponentInChildren<Button>();
                    recruitDivBut.onClick.AddListener(() => CreateDivision(id));
                }

                #endregion

                isOpen = false;
            }

            if (txtNameRota.text != "")
            {
                createRota.SetActive(true);
            }
            if (txtNameDiv.text != "")
            {
                createDiv.SetActive(true);
            }
        }

        void EnterViddil(int id)
        {
            panelViddls.SetActive(false);

            txtViddilsName.text += game.batalions[id].Name + "\n";
            tempRota.batalions.Add(game.batalions[id]);

            if (tempRota.batalions.Count > 0)
            {
                var averageValues = tempRota.CalculateAverageParametrValues();
                var sumWeaponRota = tempRota.CalculateSumWeaponQuantities();

                txtInfoRota.text = "";

                foreach (var kvp in averageValues)
                {
                    txtInfoRota.text += ($"'{kvp.Key}': {kvp.Value} \n");
                }
                txtInfoRota.text += "Зброя: \n";
                foreach (var kvp in sumWeaponRota)
                {
                    txtInfoRota.text += ($"'{kvp.Key}': {kvp.Value} \n");
                }
            }

            maxKilkViddils--;
            if(maxKilkViddils <= 0)
            {
                addVid.SetActive(false);
            }
        }

        public void CreateRotaShablon()
        {
            if (tempRota.batalions.Count <= player.parametrs[8].Value)
            {
                tempRota.Name = txtNameRota.text;
                player.shablonRotes.Add(tempRota);
                player.parametrs[8].Value -= tempRota.batalions.Count;

                tempRota = new Rotes();
                shRotes.SetActive(false);

                pl.Player = player;
                save.SavePlayers(pl);
            }
        }

        void EnterRota(int id)
        {
            panelRotts.SetActive(false);

            txtRotsName.text += player.shablonRotes[id].Name + "\n";
            tempDiv.rotes.Add(player.shablonRotes[id]);

            if (tempDiv.rotes.Count > 0)
            {
                var averageValues = tempDiv.CalculateAverageParametrValues();
                var sumWeaponRota = tempDiv.CalculateSumWeaponQuantities();

                txtInfoDiv.text = "";

                foreach (var kvp in averageValues)
                {
                    txtInfoDiv.text += ($"'{kvp.Key}': {kvp.Value} \n");
                }
                txtInfoDiv.text += "Зброя: \n";
                foreach (var kvp in sumWeaponRota)
                {
                    txtInfoDiv.text += ($"'{kvp.Key}': {kvp.Value} \n");
                }
            }

            maxKilkRot--;
            if (maxKilkRot <= 0)
            {
                addRota.SetActive(false);
            }
        }

        public void CreateDivisionShablon()
        {
            if (tempDiv.rotes.Count <= player.parametrs[8].Value)
            {
                tempDiv.Name = txtNameDiv.text;
                player.shablonDivisions.Add(tempDiv);
                player.parametrs[8].Value -= tempDiv.rotes.Count;

                tempDiv = new Divisions();
                shDivs.SetActive(false);

                pl.Player = player;
                save.SavePlayers(pl);
            }
        }

        void OpenDivision(int id)
        {
            idReg = id;
            panelDiv.gameObject.SetActive(true);
        }

        void CreateDivision(int idShabl)
        {
            Recruit tempRec = new Recruit()
            {
                shablonRecruit = player.shablonDivisions[idShabl],
                time = 10
            };

            player.regions[idReg].currentRecruitDiv = tempRec;

            // Попередньо створюємо словник для швидкого пошуку зброї за іменем
            Dictionary<string, Weapon> weaponDictionary = game.weapons.ToDictionary(weapon => weapon.Name);

            // Отримуємо кількість необхідної зброї з шаблону набору
            var requiredWeapons = tempRec.shablonRecruit.CalculateSumWeaponQuantities();

            foreach (var item in requiredWeapons)
            {
                // Пошук зброї у складі гравця
                var existingSklad = player.weaponSklad.FirstOrDefault(s => s.weapon.Name == item.Key);

                // Якщо зброя вже існує у складі, оновлюємо її кількість
                if (existingSklad != null)
                {
                    existingSklad.Kilkisty -= (int)item.Value;
                }
                else
                {
                    // Якщо зброї немає у складі, додаємо нову
                    var foundWeapon = weaponDictionary.Values.FirstOrDefault(w => w.Name.Contains(item.Key, StringComparison.OrdinalIgnoreCase));
                    if (foundWeapon != null)
                    {
                        player.weaponSklad.Add(new Sklad()
                        {
                            weapon = foundWeapon,
                            Kilkisty = -(int)item.Value
                        });
                    }
                }
            }

            pl.Player = player;
            save.SavePlayers(pl);
            panelDiv.gameObject.SetActive(false);
        }
    }
}