using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public const string MUSIC_KEY = "music";
    public const string SFX_KEY = "sfx";

    [SerializeField] AudioMixer mixer;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadVolume();
    }

    void LoadVolume()//volume saved in VolumeController.cs
    {
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 1f); //en sliders linear value
        float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY, 1f);


        mixer.SetFloat(VolumeController.MIXER_MUSIC, Mathf.Log10(musicVolume) * 20); //change to value logarithmic
        mixer.SetFloat(VolumeController.MIXER_SFX, Mathf.Log10(sfxVolume) * 20);



    }
}