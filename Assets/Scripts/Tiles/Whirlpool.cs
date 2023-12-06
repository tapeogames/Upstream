using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using static UnityEditor.Experimental.GraphView.GraphView;

public class Whirlpool : Tile
{
    public Tile[] partners;
    Vector3 posY;


    public void nextPos(SceneObject obj)
    {
        int i = 0;
        while ( i<partners.Length)
        {
            if (partners[i].activate) { obj.transform.position = partners[i].transform.position + posY; return; }
            else { i++; /*obj.enabled = true;*/ }            
        }

    }


    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("PlayerDetectorCurrent") && !PlayerController.grabbing )
        {
            posY = new Vector3(0, 1, 0);
            PlayerController player = other.GetComponentInParent<PlayerController>();
            //player.enabled= false;
            nextPos(player);
        }
                
        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing )
        {
            posY = new Vector3(0, 0.5f, 0);
            PushableObjectController obj = other.GetComponentInParent<PushableObjectController>();
            nextPos(obj);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent") && !PlayerController.grabbing)
        {
            PlayerController player = other.GetComponentInParent<PlayerController>();
            player.enabled = true;
            activate = true;
        }



        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing)
        {
            isInside = false;
            activate = true;
        }

        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            isInside = false;
        }
    }
}