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
    public float moveSpeed = 5f;
    public SceneObject playerAux;

    private void Update()
    {
        if (isMoving)
        {
            MoveToNextPositionIsMoving(partnersPosition, posY, playerAux);
        }
    }

    public void MoveToNextPositionIsMoving(Transform partner, Vector3 y, SceneObject player)
    {        
        Vector3 targetPosition = MoveToNextPosition(partner, y, player);

        if (Vector3.Distance(player.transform.position, targetPosition) < 0.1f)
        {
            Debug.Log(partner.transform.position);
            isMoving = false;
        }
    }

    public Vector3 MoveToNextPosition(Transform partner, Vector3 y, SceneObject player)
    {
        Vector3 targetPosition = partner.transform.position + y;
        float step = moveSpeed * Time.deltaTime;
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
                PlayerController.grabbing = false;
                obj.currentTile.activate = false;
                obj.ReleaseObject();
                
            }
            isMoving = true;
            isInside = true;
        }
        


        if (other.CompareTag("ObjectDetectorCurrent") && !isMoving)
        {
            posY = new Vector3(0, 1, 0);
            playerAux = other.GetComponentInParent<PushableObjectController>();
            isMoving = true;
            if (PlayerController.grabbing)
            {
                PushableObjectController obj = (PushableObjectController) playerAux;
                PlayerController.grabbing = false;
                obj.currentTile.activate = false;
                obj.ReleaseObject();
                
            }
            isInside = true;
        }

        if (other.CompareTag("ObjectDetectorCurrent") && isInside)
        {
            obj = other.GetComponentInParent<PushableObjectController>();
        }

    }
}