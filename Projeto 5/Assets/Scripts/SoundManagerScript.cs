using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManagerScript : MonoBehaviour
{
    //https://www.youtube.com/watch?v=yWCHaTwVblk

    [SerializeField] Slider VolumeSlider;
    public Text VolumeValue;

    void Start()
    {
        if(!PlayerPrefs.HasKey("GameVolume"))
        {
            PlayerPrefs.SetFloat("GameVolume", 1);
            Load();
        }

        else
        {
            Load();
        }
        
    }

    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value;
        Save();
    }

    private void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("GameVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("GameVolume", VolumeSlider.value);
    }
}
