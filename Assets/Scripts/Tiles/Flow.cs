using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : Tile
{
    public Transform partnersPosition;
    Vector3 posY = new Vector3(0, 1, 0);
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
        // Realiza un raycast para verificar si hay algún objeto en la posición dada.
        RaycastHit hit;
        return Physics.Raycast(position, Vector3.up, out hit, 1f); // Puedes ajustar la longitud del raycast según tus necesidades.
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
            playerAux = other.GetComponentInParent<PlayerController>();
            isMoving = true;
        }
        else if (other.CompareTag("ObjectDetectorCurrent") && !isMoving && !PlayerController.grabbing)
        {
            playerAux = other.GetComponentInParent<PushableObjectController>();
            isMoving = true;
        }
    }
}