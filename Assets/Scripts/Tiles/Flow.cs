using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flow : Tile
{
    public Transform partnersPosition;
    Vector3 posY;
    public bool isMoving = false;
    private float moveSpeed = 5f;
    SceneObject playerAux;

    private void Update()
    {
        if (isMoving)
        {
            MoveToNextPosition();
        }
    }

    private void MoveToNextPosition()
    {        
        Vector3 targetPosition = partnersPosition.transform.position + posY;
        float step = moveSpeed * Time.deltaTime;
        playerAux.transform.position = Vector3.MoveTowards(playerAux.transform.position, targetPosition, step);

        if (Vector3.Distance(playerAux.transform.position, targetPosition) < 0.1f)
        {
            Debug.Log(partnersPosition.transform.position);
            isMoving = false;
        }
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
                obj.ReleaseObject();
                obj.currentTile.activate = false;
                
            }
            isMoving = true;
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
                obj.ReleaseObject();
                obj.currentTile.activate = false;
                
            }
            
        }
    }
}