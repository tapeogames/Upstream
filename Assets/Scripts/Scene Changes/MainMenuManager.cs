using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void Play()
    {
        SceneManager.LoadScene(3);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
}
