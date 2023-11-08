using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whirlpool : Tile
{
    public int index;
    public Whirlpool[] whirlpools;
    Vector3 posY = new Vector3(0, 1, 0);
    

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            PlayerController player = other.GetComponentInParent<PlayerController>();
            if (index == 0)
            {
                player.playerAvatar.transform.position = whirlpools[1].transform.position + posY;

            }
            else
            {
                player.playerAvatar.transform.position = whirlpools[0].transform.position + posY;
            }
        }
        if (other.CompareTag("ObjectDetectorCurrent"))
        {

            PushableObjectController obj = other.GetComponentInParent<PushableObjectController>();
            if (index == 0)
            {
                obj.pushableObject.transform.position =whirlpools[1].transform.position + posY;

            }
            else
            {
                obj.pushableObject.transform.position = whirlpools[0].transform.position + posY;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
