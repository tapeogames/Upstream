using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool activate = true;
    public BoxCollider tileCenter;
    public bool isInside = false;

    

    void Start()
    {
        tileCenter = GetComponent<BoxCollider>();
        tileCenter.name = "tileCenter";
    }


    public Vector3 GetTilePosition()
    {
        return (Vector3.right*transform.position.x+Vector3.forward*transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing)
        {
            //Debug.Log("HA ENTRADO");
            activate = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            isInside = false;
            activate = true;
        }
        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            isInside = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerDetectorCurrent"))
        {
            isInside = true;
        }

        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            isInside = true;
        }
    }
}
