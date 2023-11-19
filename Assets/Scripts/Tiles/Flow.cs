using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Flow : Tile
{
    public Transform partnersPosition;
    public Vector3 posY;
    public bool isMoving = false;
    public float moveSpeed;
    public SceneObject playerAux;

    private void Start()
    {
        moveSpeed = 4f;
        tileCenter = GetComponent<BoxCollider>();
        tileCenter.name = "tileCenter";
    }

    private void Update()
    {
        if (isMoving)
        {
            MoveToNextPositionIsMoving(partnersPosition, playerAux);
        }
        DeactivateFlow();
    }

    public void MoveToNextPositionIsMoving(Transform partner, SceneObject player)
    {
        Vector3 partnerDef = partner.position + posY;
        Vector3 targetPosition = MoveToNextPosition(partnerDef, player, moveSpeed);
        float distance = Vector3.Distance(player.transform.position, targetPosition);

        if (distance < 0.1f)
        {
            player.transform.position = partnerDef;
            isMoving = false;
        }

    }

    public Vector3 MoveToNextPosition(Vector3 partner, SceneObject player, float speed)
    {
        Vector3 targetPosition = partner;
        float step = speed * Time.deltaTime;
        player.transform.position = Vector3.MoveTowards(player.transform.position, targetPosition, step);
        return targetPosition;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent") && !isMoving)
        {
            posY = new Vector3(0, 0.5f, 0);
            playerAux = other.GetComponentInParent<PlayerController>();
            if (PlayerController.grabbing)
            {
                PushableObjectController obj = playerAux.GetComponentInChildren<PushableObjectController>();
                obj.currentTile.activate = false;
                obj.ReleaseObject();
                PlayerController.grabbing = false;

            }
            isMoving = true;
            isInside = true;
        }
        
        if (other.CompareTag("ObjectDetectorCurrent") && !isMoving)
        {
            posY = new Vector3(0, 0.5f, 0);
            playerAux = other.GetComponentInParent<PushableObjectController>();
            if (PlayerController.grabbing)
            {
                PushableObjectController obj = (PushableObjectController) playerAux;
                
                    obj.currentTile.activate = false;
                
                obj.ReleaseObject();
                PlayerController.grabbing = false;
            }
            isMoving = true;
            isInside = true;
        }
    }

    public void DeactivateFlow()
    {
        int max = LastFlow.maxOccupied;
        int occuped = LastFlow.occupiedNum;
        //Debug.Log("maximo es: " + max + " numero de ocupados: " + occuped);

        if(max == occuped)
        {
            activate = false;
        }
        else
        {
            activate = true;
        }
    }
}