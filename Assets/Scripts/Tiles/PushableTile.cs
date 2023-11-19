using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PushableTile : Tile
{
    public PushableObjectController obj;
    public int index;
    // Start is called before the first frame update
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            isInside = false;
            activate = true;
            LastFlow.occupiedNum--;
            obj = null;
        }
        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            isInside = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing)
        {
            //Debug.Log("HA ENTRADO");
            activate = false;
        }
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            obj = other.GetComponentInParent<PushableObjectController>();
            LastFlow.objectAux[index] = obj;
            LastFlow.occupiedNum++;
        }
    }

}
