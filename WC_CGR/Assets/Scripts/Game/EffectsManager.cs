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
    public class EffectsManager : MonoBehaviour
    {
        Load load = new Load();

        Players pl = new Players();
        Country player = new Country();
        bool isOpen = false;

        public GameObject effectPr;
        public GameObject contentPar;

        Text textEf;

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
                for (int i = 0; i < player.effects.Count; i++)
                {
                    GameObject curEff = Instantiate(effectPr, contentPar.transform);
                    curEff.transform.position = new Vector3(curEff.transform.position.x, curEff.transform.position.y - (2 * i), curEff.transform.position.z);
                    textEf = curEff.GetComponentInChildren<Text>();
                    textEf.text = player.effects[i].Name + "\n";
                    for (int j = 0; j < player.effects[i].parametrs.Count; j++)
                    {
                        textEf.text += player.effects[i].parametrs[j].Name + " : " + player.effects[i].parametrs[j].Value.ToString() + "\n";
                    }
                }
                isOpen = false;
            }

        }
    }
}