using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand : Tile
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            TileDetectorObject detectorObject = other.GetComponentInParent<TileDetectorObject>();
            if (detectorObject != null)
            {
                detectorObject.ActivateIsInside();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            TileDetectorObject detectorObject = other.GetComponentInParent<TileDetectorObject>();
            if (detectorObject != null)
            {
                detectorObject.ActivateIsOutside();
            }
        }
    }

}
