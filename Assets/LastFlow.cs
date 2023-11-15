using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LastFlow : Flow
{
    // Start is called before the first frame update
    public Tile[] pushPositions;

    private bool[] occupied;
    public static int occupiedNum = 0;

    private void Update()
    {
        if (isMoving)
        {
            MoveToNextPositionIsMoving(partnersPosition, posY + posY, playerAux);
        }

        CheckTilesIsInside();

    }
    void Start()
    {
        tileCenter = GetComponent<BoxCollider>();
        tileCenter.name = "tileCenter";

        occupied = new bool[pushPositions.Length];
    }

    private bool IsPositionOccupied(Vector3 position)
    {
        RaycastHit hit;
        return Physics.Raycast(position, Vector3.up, out hit, 1f);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent") && !isInside)
        {
            CheckPosiblePosition();
            //obj = null;
            isInside = false;
            activate = true;
            
        }

        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            CheckPosiblePosition();
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

    private void FlowPush(int i)
    {
        Vector3 targetPosition = MoveToNextPosition(pushPositions[i + 1].tileCenter.transform, posY, pushPositions[i].obj);

        if (Vector3.Distance(pushPositions[i].obj.transform.position, targetPosition) < 0.1f)
        {
            pushPositions[i].isInside = false;
        }
    }

    private void CheckTilesIsInside()
    {
        int i = 0;
        while (occupied[i] && i<pushPositions.Length-1)
        {
            if (pushPositions[i].isInside)
            {
                FlowPush(i);
            }
            i++;
        }
        
    }

}
