using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand : Tile
{

    public bool isInside = false;
    public bool start = true;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent") && start)
        {
            GetComponent<Sand>().SendMessage("ActivateIsInside");
        }
    }

    public void ActivateIsInside()
    {
        isInside = true;

        start = false;
    }

}
