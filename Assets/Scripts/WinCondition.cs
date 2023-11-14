using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject win;

    private void Start()
    {
        win.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ForwardPlayer"))
        {
            win.SetActive(true);
        }
    }

}
