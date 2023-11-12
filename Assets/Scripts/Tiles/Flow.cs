using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : Tile
{
    public Transform partnersPosition;
    Vector3 posY;
    private bool isMoving = false;
    private float moveSpeed = 5f;

    SceneObject playerAux;

    private void Update()
    {
        if (isMoving)
        {
            MoveToNextPosition();
        }
    }

    private bool IsPositionOccupied(Vector3 position)
    {
        RaycastHit hit;
        return Physics.Raycast(position, Vector3.up, out hit, 1f); 
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

    private void PushObject()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent") && !isMoving)
        {
            posY = new Vector3(0, 0.5f, 0);
            playerAux = other.GetComponentInParent<PlayerController>();
            isMoving = true;
        }
        
        if (other.CompareTag("ObjectDetectorCurrent") && !isMoving && !PlayerController.grabbing)
        {
            posY = new Vector3(0, 1, 0);
            playerAux = other.GetComponentInParent<PushableObjectController>();
            isMoving = true;
        }
    }
}