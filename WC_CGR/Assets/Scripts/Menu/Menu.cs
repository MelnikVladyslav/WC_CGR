using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame(int id)
    {
        SceneManager.LoadSceneAsync(id);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
