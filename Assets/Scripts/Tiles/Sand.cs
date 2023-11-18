using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand : Tile
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing)
        {
            Debug.Log("HA ENTRADO");
            activate = false;
        }

        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            TileDetectorObject detectorObject = other.GetComponentInParent<TileDetectorObject>();
            if (detectorObject != null)
            {
                TileDetectorObject.isInside = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            activate = true;
            TileDetectorObject detectorObject = other.GetComponentInParent<TileDetectorObject>();
            if (detectorObject != null)
            {
                TileDetectorObject.isInside = false;
            }
        }
    }

    

}
