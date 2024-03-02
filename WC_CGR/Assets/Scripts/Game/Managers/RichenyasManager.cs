using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game.Managers
{
    public class RichenyasManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Players pl = new Players();
        Country player = new Country();

        public GameObject richPrefab;
        public GameObject contentPar;

        bool isOpen = false;

        Text textRivh;
        Button enterRich;

        List<int> idBtns = new List<int>();

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

        // Update is called once per frame
        void Update()
        {
            if (isOpen)
            {
                if (idBtns.Count > 0)
                {
                    for (int i = 0; i < idBtns.Count; i++)
                    {
                        if (PlayerPrefs.GetInt("kilkDayRichStab") == 0)
                        {
                            if (idBtns[i] == 0)
                            {
                                idBtns.Remove(idBtns[i]);
                            }
                        }
                        if (PlayerPrefs.GetInt("kilkDayRichWar") == 0)
                        {
                            if (idBtns[i] == 1)
                            {
                                idBtns.Remove(idBtns[i]);
                            }
                        }
                    }
                }
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < player.richenyas.Count; i++)
                {
                    GameObject curRich = Instantiate(richPrefab, contentPar.transform);
                    curRich.transform.position = new Vector3(curRich.transform.position.x, curRich.transform.position.y - (2 * i), curRich.transform.position.z);
                    textRivh = curRich.GetComponentInChildren<Text>();
                    enterRich = curRich.GetComponentInChildren<Button>();
                    textRivh.text = player.richenyas[i].Name + "\n";
                    for (int j = 0; j < player.richenyas[i].parametrs.Count; j++)
                    {
                        textRivh.text += player.richenyas[i].parametrs[j].Name + " : " + player.richenyas[i].parametrs[j].Value + "\n";
                    }

                    for (int j = 0; j < idBtns.Count; j++)
                    {
                        if (idBtns[j] == i)
                        {
                            enterRich.gameObject.SetActive(false);
                        }
                    }

                    int curId = i;
                    Button curBut = enterRich;
                    enterRich.onClick.AddListener(() => EnterRich(curId, curBut));
                }
                isOpen = false;
            }
        }

        void EnterRich(int id, Button curBtn)
        {
            curBtn.gameObject.SetActive(false);
            idBtns.Add(id);

            if (id == 0)
            {
                PlayerPrefs.SetInt("kilkDayRichStab", 200);
            }
            if (id == 1)
            {
                PlayerPrefs.SetInt("kilkDayRichWar", 200);
            }
        }
    }
}