using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Menu.Settings.Sounds
{
    public class SoundManager : MonoBehaviour
    {
        public void getVolume(Slider sl)
        {
            if (sl.value == 0)
            {
                PlayerPrefs.SetFloat("volume", 0.5f);
            }
            else
            {
                PlayerPrefs.SetFloat("volume", sl.value);
            }
        }
    }
}