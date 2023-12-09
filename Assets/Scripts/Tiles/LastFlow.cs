using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LastFlow : Flow
{
    // Start is called before the first frame update
    public PushableTile[] pushPositions;
    public static PushableObjectController[] objectAux ;
    private bool[] occupied;
    public int occupiedNumTiles; 
    public static int occupiedNum;
    public static int maxOccupied;
    public bool push = false;

    //Vector3 auxPosY = new Vector3(0, 0.5f, 0);


    void Awake()
    {
        occupiedNum = 0;
        moveSpeed = 4f;
        tileCenter = GetComponent<BoxCollider>();
        tileCenter.name = "tileCenter";

        occupied = new bool[pushPositions.Length];
        objectAux = new PushableObjectController[pushPositions.Length];
        maxOccupied = pushPositions.Length;
    }

    private void Update()
    {
        occupiedNumTiles = occupiedNum;
        if (isMoving)
        {
            MoveToNextPositionIsMoving(partnersPosition, playerAux);
        }
        if (push)
        {
            CheckTilesIsInside();
        }
        DeactivateFlow();
    }


    private bool IsPositionOccupied(Vector3 position)
    {
        RaycastHit hit;
        return Physics.Raycast(position, Vector3.up, out hit, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing)
        {
            //Debug.Log("HA ENTRADO");
            activate = false;
        }
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            CheckPosiblePosition();
        }

        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            CheckPosiblePosition();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            isInside = false;
            activate = true;
        }

        if (other.CompareTag("PlayerDetectorCurrent"))
        {
            isInside = false;
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
                if (obj.currentTile != null)
                {
                    obj.currentTile.activate = false;
                }
                obj.ReleaseObject();
                PlayerController.grabbing = false;
            }
            isMoving = true;
            isInside = true;
            push = true;
        }

        if (other.CompareTag("ObjectDetectorCurrent") && !isMoving)
        {
            posY = new Vector3(0, 0.5f, 0);
            playerAux = other.GetComponentInParent<PushableObjectController>();
            if (PlayerController.grabbing)
            {
                PushableObjectController obj = (PushableObjectController)playerAux;
                if (obj.currentTile != null)
                {
                    obj.currentTile.activate = false;
                }
                obj.ReleaseObject();
                PlayerController.grabbing = false;
            }
            isMoving = true;
            isInside = true;
            push = true;
        }
    }

    private void CheckPosiblePosition()
    {
        for (int i = 0; i < pushPositions.Length; i++)
        {
            occupied[i] = IsPositionOccupied(pushPositions[i].tileCenter.transform.position);
            /*if (occupied[i])
            {
                occupiedNum++;
            }*/
            //Debug.Log(occupied[i]);
        }
    }

    private void FlowPush(PushableObjectController aux, Vector3 targetPosition)
    {
        //Debug.Log(aux + " tiene que ir a " + targetPosition );
        Vector3 currentPosition = aux.transform.position;
        float distance = Vector3.Distance(currentPosition, targetPosition);

        //aux.transform.position = targetPosition;
        if (distance > 0.4f)//ese float es una distancia que lo que hace es aproximar el objeto dentro del tile
        {
            Vector3 newPosition = Vector3.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);
            aux.transform.position = newPosition;
        }
        else
        {
            aux.transform.position = targetPosition;
            push = false;
        }
    }

    private void CheckTilesIsInside()
    {
        //CheckPosiblePosition();
        int i = 0;
        while (occupied[i] && i < pushPositions.Length-1 && objectAux[i]!=null)
        {
            //Debug.Log(posY);
            FlowPush(objectAux[i], pushPositions[i+1].tileCenter.transform.position + new Vector3(0,0.5f,0));
            i++;
        }
        
    }

}
