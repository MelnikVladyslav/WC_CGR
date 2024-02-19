using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Game.MenuGame
{
    public class MenuGame : MonoBehaviour
    {
        public void Back()
        {
            SceneManager.LoadSceneAsync(0);
        }
    }
}