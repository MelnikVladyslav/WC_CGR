using Assets.Scripts.Class.Settings;
using GameLogic.Classes.Game;
using GameLogic.Classes.Game.Uryad.Foci;
using GameLogic.Functions.SaveLoad;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Game
{
    public class RadnuksManager : MonoBehaviour
    {
        Load load = new Load();

        Players pl = new Players();
        Country player = new Country();
        bool isOpen = false;

        public GameObject radnukPr;
        public GameObject contentPar;

        Text textRad;

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
                foreach (Transform child in contentPar.transform)
                {
                    Destroy(child.gameObject);
                }
                for (int i = 0; i < player.radnuks.Count; i++)
                {
                    GameObject curRad = Instantiate(radnukPr, contentPar.transform);
                    curRad.transform.position = new Vector3(curRad.transform.position.x, curRad.transform.position.y - (2 * i), curRad.transform.position.z);
                    textRad = curRad.GetComponentInChildren<Text>();
                    textRad.text = player.radnuks[i].Name + "\n";
                    for (int j = 0; j < player.radnuks[i].parametrs.Count; j++)
                    {
                        textRad.text += player.radnuks[i].parametrs[j].Name + " : " + player.radnuks[i].parametrs[j].Value.ToString() + "\n";
                    }
                }
                isOpen = false;
            }

        }
    }
}