using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whirlpool : Tile
{

    public Transform partnerPosition;
    Vector3 posY = new Vector3(0, 1, 0);
    public bool inside = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent") && !PlayerController.grabbing && inside)
        {
            Debug.Log("ENTRO WHIRPOOL");
            PlayerController player = other.GetComponentInParent<PlayerController>();
            player.enabled= false;
            Debug.Log("Desactivado");

            player.transform.position = partnerPosition.transform.position + posY;


        }
        
        
        
        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing)
        {
            PushableObjectController obj = other.GetComponentInParent<PushableObjectController>();
            obj.transform.position = partnerPosition.transform.position + posY;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent") && !PlayerController.grabbing)
        {
            Debug.Log("ENTRO WHIRPOOL");
            PlayerController player = other.GetComponentInParent<PlayerController>();
            player.enabled = true;
            Debug.Log("Desactivado");
            inside= false;

        }
    }
}