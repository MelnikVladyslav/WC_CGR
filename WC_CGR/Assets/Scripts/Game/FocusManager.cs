using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class FocusManager : MonoBehaviour
    {
        Save save = new Save();
        Load load = new Load();

        Players pl = new Players();
        Country player = new Country();

        public GameObject focusPr;
        public GameObject contentPar;
        public bool isOpenFoci = false;

        #region Elements Focus prefab
        Text nameF;
        Button enterF;
        List<Button> buttons = new List<Button>();
        #endregion

        #region Current focus
        public Text curNameF;
        public Text curTimeF;
        public Button curEnterF;
        #endregion

        // Use this for initialization
        void Start()
        {
            
        }

        public void Open()
        {
            isOpenFoci = true;
            pl = load.LoadPlayersInfo();
            player = pl.Player;
        }

        // Update is called once per frame
        void Update()
        {
            if (isOpenFoci)
            {
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                    buttons = new List<Button>();
                }
                for (int i = 0; i < player.treeFocuses.foci.Count; i++)
                {
                    if (player.treeFocuses.foci[i].isFoc != true)
                    {
                        if (player.treeFocuses.foci[i].isDost == true)
                        {
                            if (player.treeFocuses.foci[i].prevFoc.prevFocus.Name == "")
                            {
                                if (player.currentFocus.Name != "")
                                {
                                    curEnterF.gameObject.SetActive(false);
                                    curNameF.text = player.currentFocus.Name;
                                    curTimeF.text = player.currentFocus.KilkDayRemained + "/" + player.currentFocus.KilkDay;
                                }
                                if (player.currentFocus.Name == "")
                                {
                                    int curId = i;

                                    curNameF.text = "";
                                    curTimeF.text = "";
                                    curEnterF.gameObject.SetActive(true);

                                    GameObject curFoc = Instantiate(focusPr, contentPar.transform);
                                    curFoc.transform.position = new Vector3(curFoc.transform.position.x, curFoc.transform.position.y - (2 * i), curFoc.transform.position.z);
                                    nameF = curFoc.GetComponentInChildren<Text>();
                                    nameF.text = player.treeFocuses.foci[i].Name + " Час: " + player.treeFocuses.foci[i].KilkDay.ToString();
                                    enterF = curFoc.GetComponentInChildren<Button>();

                                    Text curT = nameF;
                                    Button curB = enterF;
                                    buttons.Add(curB);

                                    enterF.onClick.AddListener(() => EnterFocus(curId, curT, curB));
                                }
                            }
                            if (player.treeFocuses.foci[i].prevFoc.prevFocus.Name != "")
                            {
                                if (player.treeFocuses.foci[i].prevFoc.prevFocus.isFoc == true)
                                {
                                    if (player.currentFocus.Name != "")
                                    {
                                        curEnterF.gameObject.SetActive(false);
                                        curNameF.text = player.currentFocus.Name;
                                        curTimeF.text = player.currentFocus.KilkDayRemained + "/" + player.currentFocus.KilkDay;
                                    }
                                    if (player.currentFocus.Name == "")
                                    {
                                        int curId = i;

                                        curNameF.text = "";
                                        curTimeF.text = "";
                                        curEnterF.gameObject.SetActive(true);

                                        GameObject curFoc = Instantiate(focusPr, contentPar.transform);
                                        curFoc.transform.position = new Vector3(curFoc.transform.position.x, curFoc.transform.position.y - (2 * i), curFoc.transform.position.z);
                                        nameF = curFoc.GetComponentInChildren<Text>();
                                        nameF.text = player.treeFocuses.foci[i].Name + " Час: " + player.treeFocuses.foci[i].KilkDay.ToString();
                                        enterF = curFoc.GetComponentInChildren<Button>();

                                        Text curT = nameF;
                                        Button curB = enterF;
                                        buttons.Add(curB);

                                        enterF.onClick.AddListener(() => EnterFocus(curId, curT, curB));
                                    }
                                }
                            }
                        }
                    }
                    isOpenFoci = false;
                }
            }
        }

        void EnterFocus(int id, Text curNameF, Button curEnterF)
        {
            player.currentFocus = player.treeFocuses.foci[id];
            curEnterF.gameObject.SetActive(false);
            curNameF.text = player.treeFocuses.foci[id].Name + " " + player.treeFocuses.foci[id].KilkDayRemained + "/" + player.treeFocuses.foci[id].KilkDay;
            
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].gameObject.SetActive(false);
            }

            this.curEnterF.gameObject.SetActive(false);
            this.curNameF.text = player.treeFocuses.foci[id].Name;
            curTimeF.text = player.treeFocuses.foci[id].KilkDayRemained + "/" + player.treeFocuses.foci[id].KilkDay;

            pl.Player = player;
            save.SavePlayers(pl);
        }
    }
}