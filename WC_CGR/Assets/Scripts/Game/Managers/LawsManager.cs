using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Classes.Game.Uryad.Zakonu;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.EventSystems.EventTrigger;

namespace Assets.Scripts.Game.Managers
{
    public class LawsManager : MonoBehaviour
    {
        Load load = new Load();
        Save save = new Save();

        Players pl = new Players();
        StartGame game;
        Country player = new Country();

        public GameObject lawPrefab;
        public GameObject contentPar;

        bool isMob = false;
        bool isImport = false;
        bool isEc = false;

        Text textLaw;
        Button enterLaw;

        // Use this for initialization
        void Start()
        {

        }

        public void OpenMob()
        {
            isMob = true;
            pl = load.LoadPlayersInfo();
            game = load.LoadStartInfo();
            player = pl.Player;
        }

        public void OpenImport()
        {
            isImport = true;
            pl = load.LoadPlayersInfo();
            game = load.LoadStartInfo();
            player = pl.Player;
        }

        public void OpenEc()
        {
            isEc = true;
            pl = load.LoadPlayersInfo();
            game = load.LoadStartInfo();
            player = pl.Player;
        }

        // Update is called once per frame
        void Update()
        {
            if (isImport)
            {
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < 2; i++)
                {
                    GameObject curLaw = Instantiate(lawPrefab, contentPar.transform);
                    curLaw.transform.position = new Vector3(curLaw.transform.position.x, curLaw.transform.position.y - (2 * i), curLaw.transform.position.z);
                    textLaw = curLaw.GetComponentInChildren<Text>();
                    enterLaw = curLaw.GetComponentInChildren<Button>();
                    textLaw.text = game.zakonus[i].Name + "\n";
                    for (int j = 0; j < game.zakonus[i].parametrs.Count; j++)
                    {
                        textLaw.text += game.zakonus[i].parametrs[j].Name + " : " + game.zakonus[i].parametrs[j].Value + "\n";
                    }
                    textLaw.text += "Price: " + game.zakonus[i].Price.Value.ToString();

                    Button curBut = enterLaw;
                    for (int j = 0; j < player.zakonus.Count; j++)
                    {
                        if (game.zakonus[i].Type == TypeZak.ImportExport)
                        {
                            if (game.zakonus[i].Name == player.zakonus[j].Name)
                            {
                                curBut.gameObject.SetActive(false);
                            }
                        }
                    }

                    int curId = i;
                    enterLaw.onClick.AddListener(() => Enter(curId, TypeZak.ImportExport));
                }
                isImport = false;
            }
            if (isEc)
            {
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 7; i < 9; i++)
                {
                    GameObject curLaw = Instantiate(lawPrefab, contentPar.transform);
                    curLaw.transform.position = new Vector3(curLaw.transform.position.x, curLaw.transform.position.y - (2 * i), curLaw.transform.position.z);
                    textLaw = curLaw.GetComponentInChildren<Text>();
                    enterLaw = curLaw.GetComponentInChildren<Button>();
                    textLaw.text = game.zakonus[i].Name + "\n";
                    for (int j = 0; j < game.zakonus[i].parametrs.Count; j++)
                    {
                        textLaw.text += game.zakonus[i].parametrs[j].Name + " : " + game.zakonus[i].parametrs[j].Value + "\n";
                    }
                    textLaw.text += "Price: " + game.zakonus[i].Price.Value.ToString();

                    Button curBut = enterLaw;
                    for (int j = 0; j < player.zakonus.Count; j++)
                    {
                        if (game.zakonus[i].Type == TypeZak.Economic)
                        {
                            if (game.zakonus[i].Name == player.zakonus[j].Name)
                            {
                                curBut.gameObject.SetActive(false);
                            }
                        }
                    }

                    int curId = i;
                    enterLaw.onClick.AddListener(() => Enter(curId, TypeZak.Economic));
                }
                isEc = false;
            }
        }

        void Enter(int id, TypeZak type)
        {
            if (player.parametrs[0].Value > game.zakonus[id].Price.Value)
            {
                player.parametrs[0].Value -= game.zakonus[id].Price.Value;
                for (int i = 0; i < player.zakonus.Count; i++)
                {
                    if (player.zakonus[i].Type == type)
                    {
                        player.zakonus.Remove(player.zakonus[i]);
                    }
                }
                player.zakonus.Add(game.zakonus[id]);
            }

            pl.Player = player;
            save.SavePlayers(pl);
        }
    }
}