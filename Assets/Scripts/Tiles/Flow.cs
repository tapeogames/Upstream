using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Flow : Tile
{
    public Transform[] partnersPosition;
    private int index = 0;
    Vector3 posY = new Vector3(0, 1, 0);
    private bool isMoving = false;
    private float moveSpeed = 5f;

    PlayerController playerAux;

    private void Update()
    {
        if (isMoving)
        {
            MoveToNextPosition();
        }
    }

    private void MoveToNextPosition()
    {
        if (index < partnersPosition.Length)
        {
            Vector3 targetPosition = partnersPosition[index].position + posY;
            float step = moveSpeed * Time.deltaTime;
            playerAux.transform.position = Vector3.MoveTowards(playerAux.transform.position, targetPosition, step);
            playerAux.enabled = false;

            if (Vector3.SqrMagnitude(playerAux.transform.position - targetPosition) < 0.0001f)
            {
                index++;
            }
        }
        else
        {
            isMoving = false;
            playerAux.enabled = true; 
            index = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            playerAux = other.GetComponentInParent<PlayerController>();
            isMoving = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            if (!isMoving)
            {
                playerAux.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            PlayerController player = other.GetComponentInParent<PlayerController>();
            player.enabled = true;
        }
    }
}
