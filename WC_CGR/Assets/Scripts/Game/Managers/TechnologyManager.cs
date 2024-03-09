using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Army.Weaponry;
using GameLogic.Classes.Game.Technolog;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Managers
{
    public class TechnologyManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Players pl = new Players();
        Country player = new Country();
        bool isOpen = false;

        public GameObject techPr;
        public GameObject contentPar;

        Text nameTechPr;
        Button enterTechPr;

        #region Slot

        public Text nameTech;
        public Text timeTech;
        public Button enterSlot;

        #endregion

        #region boolValues

        bool isArmy = false;
        bool isEconomic = false;
        bool isTech = false;
        bool isInfantry = false;
        bool isArta = false;
        bool isTechnika = false;
        bool isAvia = false;

        #endregion

        // Use this for initialization
        void Start()
        {

        }

        #region EnterMetods
        public void Open()
        {
            isOpen = true;
            isAvia = true;
            isInfantry = true;
            isArmy = true;
            isArta = true;
            isEconomic = true;
            isTech = true;
            isTechnika = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        public void EnterArmy()
        {
            isArmy = true;
        }

        public void EnterIndustry()
        {
            isEconomic = true;
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        public void EnterTechs()
        {
            isTech = true;
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        public void EnterInfantry()
        {
            isInfantry = true;
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        public void EnterArta()
        {
            isArta = true;
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        public void EnterTechnika()
        {
            isTechnika = true;
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        public void EnterAvia()
        {
            isAvia = true;
            isOpen = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }
        #endregion

        // Update is called once per frame
        void Update()
        {
            if(isOpen)
            {
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                if(isArmy)
                {
                    if(isInfantry)
                    {
                        for (int i = 0; i < player.technologies.Count; i++)
                        {
                            if (player.technologies[i].IsTech != true)
                            {
                                if (player.technologies[i].prevTech.prevTech.Name != "")
                                {
                                    if (player.technologies[i].prevTech.prevTech.IsTech == true)
                                    {
                                        if (player.currentTech.Name != "")
                                        {
                                            enterSlot.gameObject.SetActive(false);
                                            nameTech.text = player.currentTech.Name;
                                            timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                        }
                                        if (player.currentTech.Name == "")
                                        {
                                            enterSlot.gameObject.SetActive(true);
                                            if (player.technologies[i].Type == TypeTech.Army)
                                            {
                                                if (i > 0 && i <= 7)
                                                {
                                                    int curId = i;

                                                    nameTech.text = "";
                                                    timeTech.text = "";
                                                    enterSlot.enabled = true;

                                                    GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                    curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                    nameTechPr = curTech.GetComponentInChildren<Text>();
                                                    nameTechPr.text = player.technologies[i].Name + "\n";
                                                    for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                    {
                                                        nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                    }
                                                    if (player.technologies[i].weapon.Name != "")
                                                    {
                                                        nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                    }
                                                    nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                    enterTechPr = curTech.GetComponentInChildren<Button>();

                                                    Text curT = nameTechPr;

                                                    enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(isArta)
                    {
                        for (int i = 0; i < player.technologies.Count; i++)
                        {
                            if (player.technologies[i].IsTech != true)
                            {
                                if (player.technologies[i].prevTech.prevTech.Name != "")
                                {
                                    if (player.technologies[i].prevTech.prevTech.IsTech == true)
                                    {
                                        if (player.currentTech.Name != "")
                                        {
                                            enterSlot.gameObject.SetActive(false);
                                            nameTech.text = player.currentTech.Name;
                                            timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                        }
                                        if (player.currentTech.Name == "")
                                        {
                                            enterSlot.gameObject.SetActive(true);
                                            if (player.technologies[i].Type == TypeTech.Army)
                                            {
                                                if (i > 8 && i <= 40)
                                                {
                                                    int curId = i;

                                                    nameTech.text = "";
                                                    timeTech.text = "";
                                                    enterSlot.enabled = true;

                                                    GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                    curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                    nameTechPr = curTech.GetComponentInChildren<Text>();
                                                    nameTechPr.text = player.technologies[i].Name + "\n";
                                                    for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                    {
                                                        nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                    }
                                                    if (player.technologies[i].weapon.Name != "")
                                                    {
                                                        nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                    }
                                                    nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                    enterTechPr = curTech.GetComponentInChildren<Button>();

                                                    Text curT = nameTechPr;

                                                    enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(isTechnika)
                    {
                        for (int i = 0; i < player.technologies.Count; i++)
                        {
                            if (player.technologies[i].IsTech != true)
                            {
                                if (player.technologies[i].prevTech.prevTech.Name != "")
                                {
                                    if (player.technologies[i].prevTech.prevTech.IsTech == true)
                                    {
                                        if (player.currentTech.Name != "")
                                        {
                                            enterSlot.gameObject.SetActive(false);
                                            nameTech.text = player.currentTech.Name;
                                            timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                        }
                                        if (player.currentTech.Name == "")
                                        {
                                            enterSlot.gameObject.SetActive(true);
                                            if (player.technologies[i].Type == TypeTech.Army)
                                            {
                                                if (i >= 41 && i < 65)
                                                {
                                                    int curId = i;

                                                    nameTech.text = "";
                                                    timeTech.text = "";
                                                    enterSlot.enabled = true;

                                                    GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                    curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                    nameTechPr = curTech.GetComponentInChildren<Text>();
                                                    nameTechPr.text = player.technologies[i].Name + "\n";
                                                    for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                    {
                                                        nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                    }
                                                    if (player.technologies[i].weapon.Name != "")
                                                    {
                                                        nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                    }
                                                    nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                    enterTechPr = curTech.GetComponentInChildren<Button>();

                                                    Text curT = nameTechPr;

                                                    enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(isAvia)
                    {
                        for (int i = 0; i < player.technologies.Count; i++)
                        {
                            if (player.technologies[i].IsTech != true)
                            {
                                if (player.technologies[i].prevTech.prevTech.Name != "")
                                {
                                    if (player.technologies[i].prevTech.prevTech.IsTech == true)
                                    {
                                        if (player.currentTech.Name != "")
                                        {
                                            enterSlot.gameObject.SetActive(false);
                                            nameTech.text = player.currentTech.Name;
                                            timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                        }
                                        if (player.currentTech.Name == "")
                                        {
                                            enterSlot.gameObject.SetActive(true);
                                            if (player.technologies[i].Type == TypeTech.Army)
                                            {
                                                if (i >= 65 && i < 81)
                                                {
                                                    int curId = i;

                                                    nameTech.text = "";
                                                    timeTech.text = "";
                                                    enterSlot.enabled = true;

                                                    GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                    curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                    nameTechPr = curTech.GetComponentInChildren<Text>();
                                                    nameTechPr.text = player.technologies[i].Name + "\n";
                                                    for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                    {
                                                        nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                    }
                                                    if (player.technologies[i].weapon.Name != "")
                                                    {
                                                        nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                    }
                                                    nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                    enterTechPr = curTech.GetComponentInChildren<Button>();

                                                    Text curT = nameTechPr;

                                                    enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if(isEconomic)
                {
                    for (int i = 0; i < player.technologies.Count; i++)
                    {
                        if (player.technologies[i].IsTech != true)
                        {
                            if (player.technologies[i].prevTech.prevTech.Name == "")
                            {
                                if (player.technologies[i].prevTech.prevTech.IsTech == true)
                                {
                                    if (player.currentTech.Name != "")
                                    {
                                        enterSlot.gameObject.SetActive(false);
                                        nameTech.text = player.currentTech.Name;
                                        timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                    }
                                    if (player.currentTech.Name == "")
                                    {
                                        enterSlot.gameObject.SetActive(true);
                                        if (player.technologies[i].Type == TypeTech.Economic)
                                        {
                                            if (i >= 81 && i <= 86)
                                            {
                                                int curId = i;

                                                nameTech.text = "";
                                                timeTech.text = "";
                                                enterSlot.enabled = true;

                                                GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                nameTechPr = curTech.GetComponentInChildren<Text>();
                                                nameTechPr.text = player.technologies[i].Name + "\n";
                                                for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                {
                                                    nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                }
                                                if (player.technologies[i].weapon.Name != "")
                                                {
                                                    nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                }
                                                nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                enterTechPr = curTech.GetComponentInChildren<Button>();

                                                Text curT = nameTechPr;

                                                enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                            }
                                        }
                                    }
                                }
                            }
                            if (player.technologies[i].prevTech.prevTech.Name != "")
                            {
                                if (player.technologies[i].prevTech.prevTech.IsTech == true)
                                {
                                    if (player.currentTech.Name != "")
                                    {
                                        enterSlot.gameObject.SetActive(false);
                                        nameTech.text = player.currentTech.Name;
                                        timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                    }
                                    if (player.currentTech.Name == "")
                                    {
                                        enterSlot.gameObject.SetActive(true);
                                        if (player.technologies[i].Type == TypeTech.Economic)
                                        {
                                            if (i > 81 && i <= 86)
                                            {
                                                int curId = i;

                                                nameTech.text = "";
                                                timeTech.text = "";
                                                enterSlot.enabled = true;

                                                GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                nameTechPr = curTech.GetComponentInChildren<Text>();
                                                nameTechPr.text = player.technologies[i].Name + "\n";
                                                for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                {
                                                    nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                }
                                                if (player.technologies[i].weapon.Name != "")
                                                {
                                                    nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                }
                                                nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                enterTechPr = curTech.GetComponentInChildren<Button>();

                                                Text curT = nameTechPr;

                                                enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                            }
                                        }
                                    }
                                }
                                if (player.technologies[i].prevTech.prevTech.IsTech != true)
                                {
                                    if (player.currentTech.Name != "")
                                    {
                                        enterSlot.gameObject.SetActive(false);
                                        nameTech.text = player.currentTech.Name;
                                        timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                    }
                                    if (player.currentTech.Name == "")
                                    {
                                        enterSlot.gameObject.SetActive(true);
                                        if (player.technologies[i].Type == TypeTech.Economic)
                                        {
                                            if (i >= 81 && i <= 86)
                                            {
                                                int curId = i;

                                                nameTech.text = "";
                                                timeTech.text = "";
                                                enterSlot.enabled = true;

                                                GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                nameTechPr = curTech.GetComponentInChildren<Text>();
                                                nameTechPr.text = player.technologies[i].Name + "\n";
                                                for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                {
                                                    nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                }
                                                if (player.technologies[i].weapon.Name != "")
                                                {
                                                    nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                }
                                                nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                enterTechPr = curTech.GetComponentInChildren<Button>();

                                                Text curT = nameTechPr;

                                                enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if(isTech)
                {
                    for (int i = 0; i < player.technologies.Count; i++)
                    {
                        if (player.technologies[i].IsTech != true)
                        {
                            if (player.technologies[i].prevTech.prevTech.Name != "")
                            {
                                if (player.technologies[i].prevTech.prevTech.IsTech == true)
                                {
                                    if (player.currentTech.Name != "")
                                    {
                                        enterSlot.gameObject.SetActive(false);
                                        nameTech.text = player.currentTech.Name;
                                        timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                    }
                                    if (player.currentTech.Name == "")
                                    {
                                        enterSlot.gameObject.SetActive(true);
                                        if (player.technologies[i].Type == TypeTech.Tech)
                                        {
                                            if (i > 87 && i <= 91)
                                            {
                                                int curId = i;

                                                nameTech.text = "";
                                                timeTech.text = "";
                                                enterSlot.enabled = true;

                                                GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                nameTechPr = curTech.GetComponentInChildren<Text>();
                                                nameTechPr.text = player.technologies[i].Name + "\n";
                                                for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                {
                                                    nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                }
                                                if (player.technologies[i].weapon.Name != "")
                                                {
                                                    nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                }
                                                nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                enterTechPr = curTech.GetComponentInChildren<Button>();

                                                Text curT = nameTechPr;

                                                enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                            }
                                        }
                                    }
                                }

                                if (player.technologies[i].prevTech.prevTech.IsTech != true)
                                {
                                    if (player.currentTech.Name != "")
                                    {
                                        enterSlot.gameObject.SetActive(false);
                                        nameTech.text = player.currentTech.Name;
                                        timeTech.text = player.currentTech.KilkDayRemained + "/" + player.currentTech.KilkDay;
                                    }
                                    if (player.currentTech.Name == "")
                                    {
                                        enterSlot.gameObject.SetActive(true);
                                        if (player.technologies[i].Type == TypeTech.Tech)
                                        {
                                            if (i >= 87 && i <= 91)
                                            {
                                                int curId = i;

                                                nameTech.text = "";
                                                timeTech.text = "";
                                                enterSlot.enabled = true;

                                                GameObject curTech = Instantiate(techPr, contentPar.transform);
                                                curTech.transform.position = new Vector3(curTech.transform.position.x, curTech.transform.position.y - (2 * i), curTech.transform.position.z);
                                                nameTechPr = curTech.GetComponentInChildren<Text>();
                                                nameTechPr.text = player.technologies[i].Name + "\n";
                                                for (int j = 0; j < player.technologies[i].parametrs.Count; j++)
                                                {
                                                    nameTechPr.text += player.technologies[i].parametrs[j].Name + ": " + player.technologies[i].parametrs[j].Value.ToString() + "\n";
                                                }
                                                if (player.technologies[i].weapon.Name != "")
                                                {
                                                    nameTechPr.text += "Стане доступна: " + player.technologies[i].weapon.Name + "\n";
                                                }
                                                nameTechPr.text += "Час: " + player.technologies[i].KilkDay.ToString();
                                                enterTechPr = curTech.GetComponentInChildren<Button>();

                                                Text curT = nameTechPr;

                                                enterTechPr.onClick.AddListener(() => EnterTech(curId, curT));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                isOpen = false;
                isEconomic = false;
                isArta = false;
                isArmy = false;
                isAvia = false;
                isInfantry = false;
                isTech = false;
                isTechnika = false;
            }
        }

        void EnterTech(int id, Text curName)
        {
            player.currentTech = player.technologies[id];
            curName.text = player.technologies[id].Name + " " + player.technologies[id].KilkDayRemained + "/" + player.technologies[id].KilkDay;

            this.nameTech.text = player.technologies[id].Name;
            this.timeTech.text = player.technologies[id].KilkDayRemained + "/" + player.technologies[id].KilkDay;

            pl.Player = player;
            save.SavePlayers(pl);
        }
    }
}