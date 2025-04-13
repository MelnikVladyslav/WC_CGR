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
    public class GeneralsManager : MonoBehaviour
    {
        Load load = new Load();

        Players pl = new Players();
        Country player = new Country();
        bool isOpen = false;

        public GameObject generalPr;
        public GameObject contentPar;

        Text textGen;

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
                for (int i = 0; i < player.generals.Count; i++)
                {
                    GameObject curEff = Instantiate(generalPr, contentPar.transform);
                    curEff.transform.position = new Vector3(curEff.transform.position.x, curEff.transform.position.y - (2 * i), curEff.transform.position.z);
                    textGen = curEff.GetComponentInChildren<Text>();
                    textGen.text = player.generals[i].Name + "\n Attack: " + player.generals[i].AttackB + "\t Deffence: " + player.generals[i].DefenceB + "\t Move: " + player.generals[i].MoveB;
                }
                isOpen = false;
            }

        }
    }
}