using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public Canvas win;

    private void Start()
    {
        win.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ForwardPlayer"))
        {
            //Debug.Log("entra trigger");
            win.enabled = true;
        }
    }

    public void Quitar()
    {
        win.enabled = false;
    }
}
