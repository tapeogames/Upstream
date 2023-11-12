using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flow : Tile
{
    public Transform[] partnersPosition;
    private int index = 0;
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
        // Realiza un raycast para verificar si hay alg�n objeto en la posici�n dada.
        RaycastHit hit;
        return Physics.Raycast(position, Vector3.up, out hit, 1f); // Puedes ajustar la longitud del raycast seg�n tus necesidades.
    }

    private void MoveToNextPosition()
    {
        
        if (index < partnersPosition.Length)
        {
            Vector3 targetPosition = partnersPosition[index].position + posY;
            float step = moveSpeed * Time.deltaTime;
            playerAux.transform.position = Vector3.MoveTowards(playerAux.transform.position, targetPosition, step);

            if (Vector3.Distance(playerAux.transform.position, targetPosition) < 0.001f)
            {
                Debug.Log(partnersPosition[index].transform.position);
                isMoving = false;
            }
        }
        else
        {
            isMoving = false;
        }       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent") && !isMoving)
        {
            playerAux = other.GetComponentInParent<PlayerController>();
            isMoving = true;
            index++;
            if (index >= partnersPosition.Length)
            {
                index = 0;
            }
        }
        if (other.CompareTag("ObjectDetectorCurrent") && !isMoving && !PlayerController.grabbing)
        {
            PushableObjectController pushableObject = other.GetComponentInParent<PushableObjectController>();
            playerAux = other.GetComponentInParent<PushableObjectController>();
            isMoving = true;
            index++;
            if (index >= partnersPosition.Length)
            {
                index = 0;
            }
        }
    }
}