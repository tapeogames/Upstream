using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    public GameObject victoria;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ForwardPlayer"))
        {
            Debug.Log("entra trigger");
            victoria.SetActive(true);
        }
    }

}
