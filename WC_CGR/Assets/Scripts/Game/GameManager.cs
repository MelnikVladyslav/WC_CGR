using GameLogic.Classes.Game;
using GameLogic.Classes.Settings;
using GameLogic.Functions.SaveLoad;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    #region Audio
    public AudioSource audio;
    #endregion

    #region MiniMenu
    public GameObject MiniMenu;
    #endregion

    #region Bools values
    bool isStartGame = false;
    #endregion

    #region Start game
    public Dropdown dropdownCountries;
    public Dropdown dropdownKilkPl;
    Load load = new Load();
    List<Country> countries = new List<Country>();
    StartGame loadStartInit;
    Random random = new Random();
    #endregion

    #region Game
    Country player;
    int kilkPl;
    List<Country> listBots = new List<Country>();
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        #region Audio
        audio.volume = PlayerPrefs.GetFloat("volume");
        #endregion

        #region Init dropdown
        loadStartInit = load.LoadStartInfo();
        countries = loadStartInit.countries;

        List<string> countOptNames = new List<string>();
        foreach (Country country in countries)
        {
            countOptNames.Add(country.Name);
        }

        dropdownCountries.AddOptions(countOptNames);
        #endregion
    }

    public void StartGame()
    {
        player = countries[dropdownCountries.value];
        kilkPl = Convert.ToInt32(dropdownKilkPl.options[dropdownKilkPl.value].text);

        for (int i = 0; i < kilkPl - 1; i++)
        {
            int rand = random.Next(0, countries.Count);
            if (rand == player.Id)
            {
                rand = random.Next(0, countries.Count);
            }
            listBots.Add(countries[rand]);
        }
        isStartGame = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MiniMenu.SetActive(true);
        }
    }
}
