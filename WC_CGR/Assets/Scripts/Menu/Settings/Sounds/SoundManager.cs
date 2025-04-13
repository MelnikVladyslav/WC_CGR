using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Menu.Settings.Sounds
{
    public class SoundManager : MonoBehaviour
    {
        public void getVolume(Slider sl)
        {
            PlayerPrefs.SetFloat("volume", sl.value);
        }
    }
}