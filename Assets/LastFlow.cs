using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LastFlow : Flow
{
    // Start is called before the first frame update
    public Tile[] pushPositions;
    public static PushableObjectController[] objectAux ;
    private bool[] occupied;
    public static int occupiedNum = 0;
    Vector3 auxPosY;
    void Start()
    {
        moveSpeed = 4f;
        tileCenter = GetComponent<BoxCollider>();
        tileCenter.name = "tileCenter";

        occupied = new bool[pushPositions.Length];
        objectAux = new PushableObjectController[pushPositions.Length];
        for(int i = 0; i < objectAux.Length; i++)
        {
            pushPositions[i].index= i;
        }
    }
    private void Update()
    {
        if (isMoving)
        {
            MoveToNextPositionIsMoving(partnersPosition, posY, playerAux);
            CheckTilesIsInside();
        }
    }


    private bool IsPositionOccupied(Vector3 position)
    {
        RaycastHit hit;
        return Physics.Raycast(position, Vector3.up, out hit, 1f);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            auxPosY = posY;
            CheckPosiblePosition();
            obj = null;
            isInside = false;
            activate = true;
            
        }

        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            auxPosY = 2 * posY;
            CheckPosiblePosition();
            isInside = false;

        }

    }
    private void CheckPosiblePosition()
    {
        for (int i = 0; i < pushPositions.Length; i++)
        {
            occupied[i] = IsPositionOccupied(pushPositions[i].tileCenter.transform.position);
            if (occupied[i])
            {
                occupiedNum++;
            }
            Debug.Log(occupied[i]);
        }
    }

    private void FlowPush(int i, PushableObjectController aux)
    {
        Debug.Log(aux+ " tiene que ir a "+ pushPositions[i + 1].transform.position);
        Vector3 targetPosition = MoveToNextPosition(pushPositions[i + 1].tileCenter.transform, auxPosY, aux, moveSpeed);

        if (Vector3.Distance(aux.transform.position, targetPosition) < 0.5f)
        {
            aux.transform.position = pushPositions[i+1].tileCenter.transform.position + auxPosY;
            
        }
    }

    private void CheckTilesIsInside()
    {
        int i = 0;
        while (occupied[i] && i < pushPositions.Length-1)
        {
            FlowPush(i, objectAux[i]);
            i++;
        }
        
    }

}
