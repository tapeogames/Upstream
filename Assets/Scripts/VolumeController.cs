using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;
  

    public const string MIXER_MUSIC = "Music";
    public const string MIXER_SFX = "SFX";
  


    void Awake()
    {

        musicSlider.onValueChanged.AddListener(SetMusic); //comprobar si el valor del slider music cambia y llama a la funcion
        sfxSlider.onValueChanged.AddListener(SetSfx); //comprobar si el valor del slider sfx cambia y llama a la funcion
        
    }

    void Start()
    {

        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f);
        sfxSlider.value = PlayerPrefs.GetFloat(AudioManager.SFX_KEY, 1f);


    }

    void OnDisable() //values of slider saved
    {
        PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);
        PlayerPrefs.SetFloat(AudioManager.SFX_KEY, sfxSlider.value);
    }

 
    public void SetMusic(float volume) //cambiar el volumen
    {

        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(volume) * 20); //cogemos el paramtero expuesto Music del audioMixer y le cambiamos el valor al del slider
        //valor del slider cambiarlo a logaritmico (como va el audio)
        //PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);//guardar valor slider
    }

    public void SetSfx(float volume) //cambiar el volumen
    {

        mixer.SetFloat(MIXER_SFX, Mathf.Log10(volume) * 20); //cogemos el paramtero expuesto SFX del audioMixer y le cambiamos el valor al del slider
                                                             //valor del slider ya adaptado a valores del mixer (-80-0)
        //PlayerPrefs.SetFloat(AudioManager.SFX_KEY, sfxSlider.value);//guardar valor slider
    }

    




}
