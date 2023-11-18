using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    //[SerializeField] private AudioMixer audioMixer;
    private void Start()
    {
        Time.timeScale = 1.0f;
    }
    public void Exit()
    {
        SceneManager.LoadScene(3);
    }

    public void CambiarVolumen(float volumen)
    {
       // audioMixer.SetFloat("Volumen", volumen);
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
    }

}
