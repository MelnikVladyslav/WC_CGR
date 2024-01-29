using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Audio
    public AudioSource audio;
    #endregion

    #region MiniMenu
    public GameObject MiniMenu;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        audio.volume = PlayerPrefs.GetFloat("volume");
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
