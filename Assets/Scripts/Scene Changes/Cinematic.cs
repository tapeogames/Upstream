using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematic : MonoBehaviour
{
    public Animator animator;
    public GameObject level0Activator;


    void Start()
    {
        Invoke("CinematicAnimation",1);
        Invoke("ActivateSceneChange", 32);
    }

    public void CinematicAnimation()
    {
        animator.Play("Cinematic");
    }

    public void ActivateSceneChange()
    {
        level0Activator.SetActive(true);
    }
}
