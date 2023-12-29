using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.Audio;
using UnityEngine.UI;
public class setBGM : MonoBehaviour
{
    public AudioMixer BGM_mixer;
    public Slider BGM_slider;
    
    private float MusicVolumeDefaultValue = 0.75f;

    private User bgmUser;
    void Start()
    {
        init(); 
    }
    
    void init()
    {
        //BGM_slider.value = bgmUser.bgmVolume;
        BGM_mixer.SetFloat("BGM", MusicVolumeDefaultValue);
    }

    public float GetDefaultBGMVolumeValue()
    {
        return MusicVolumeDefaultValue;
    }
    public void AudioControl()
    {
        float sound = BGM_slider.value;

        if (sound == -40f)
        {
            BGM_mixer.SetFloat("BGM", -80);
        }
        else
        {
            BGM_mixer.SetFloat("BGM", sound);
        }
    }
    public void OnClickToggleVolume()
    {
        float sound = BGM_slider.value;
        if (sound > -40f)
        {
            sound = -80f;

        }
        else
        {
            sound = 0;
        }
        BGM_slider.value = sound;
        BGM_mixer.SetFloat("BGM", sound);
    }
}
