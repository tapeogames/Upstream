using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public bool winLevel;

    public GameObject win;
    public GameObject pauseButton;
    public int levelToUnlock;

    public int movementCont;
    public TimeScript time;

    public int minutes, seconds, cents;

    public string movementString;
    public string timeString;

    public bool send;
    public int currentLevel;

    void Awake()
    {
        winLevel = false;
        movementCont = 0;
    }

    private void Start()
    {
        win.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ForwardPlayer"))
        {
            //tiempo final del nivel

            time.stop = false;
            minutes = (int)(time.timeElapsed / 60f);
            seconds = (int)(time.timeElapsed - minutes * 60f);
            cents = (int)((time.timeElapsed - (int)time.timeElapsed) * 100f);
            timeString = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);

            //movimientos finales del nivel
            PlayerController p = other.GetComponentInParent<PlayerController>();
            movementCont = p.movementCont;
            movementString = "" + movementCont.ToString();
            winLevel = true;


            win.SetActive(true);
            pauseButton.SetActive(false);
           int lastLevel = PlayerPrefs.GetInt("levelReached");
            if (levelToUnlock > lastLevel) { 
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
            }

            send = true;
        }
    }

}
