using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public GameObject playerAvatar;
    public Transform playerOrigin; //el transform del player
    public Tile currentTile;

    public Tile leftTile;
    public Tile rightTile;
    public Tile forwardTile;
    public Tile backwardTile;

    public float speed;
    public float rotationSpeed;
    public bool moving;
    public bool rotating;
    public Vector3 movingDirection;
    public Vector3 targetPosition;
    public float distanceToTarget;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
        if (moving)
        {
            PerformMovement();
            
        }
        if (rotating)
        {
            RotateTowardsDirection();
        }


    }

    void ReadInput() {

        
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (leftTile != null)
                {
                    MoveToPosition(leftTile.GetTilePosition());
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (rightTile != null)
                {
                    MoveToPosition(rightTile.GetTilePosition());
                }
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (forwardTile != null)
                {
                    MoveToPosition(forwardTile.GetTilePosition());
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (backwardTile != null)
                {
                    MoveToPosition(backwardTile.GetTilePosition());
                }
            }
        



    } 

    void PerformMovement()
    {
        transform.position += movingDirection * speed * Time.deltaTime;
        float currentDistance = (targetPosition - transform.position).magnitude;
        if (distanceToTarget < currentDistance)
        {
            moving = false;
            transform.position = targetPosition;
        }
        else
        {
            distanceToTarget = currentDistance;
        }
    }

    void RotateTowardsDirection()
    {
        /*Vector3 nextPosition = new Vector3(targetPosition.x, 0, targetPosition.z);
        Debug.Log(nextPosition);
        Vector3 position = new Vector3(playerOrigin.position.x, 0, playerOrigin.position.z);
        rotating = false;
        Vector3 lookAt = (nextPosition - position).normalized;
        Debug.Log(lookAt);
        playerAvatar.transform.Rotate(lookAt);
        Debug.Log(playerAvatar.transform.forward.normalized);*/



        ///hay algo raro en este codigo funciona pero mira hacia abajo
        Vector3 newRotation = Vector3.RotateTowards(playerAvatar.transform.forward, movingDirection, rotationSpeed*Time.deltaTime, 1f);
        if ((playerAvatar.transform.eulerAngles-newRotation).magnitude<0.2f)
        {
            rotating = false;
            playerAvatar.transform.rotation = Quaternion.LookRotation(movingDirection);
        }
        else
        {
            playerAvatar.transform.rotation = Quaternion.LookRotation(newRotation);
        }

    }

    public void MoveToPosition(Vector3 position)
    {
        targetPosition = position;
        movingDirection = (position - transform.position);
        distanceToTarget = movingDirection.magnitude;
        movingDirection = movingDirection.normalized;
        moving = true;
        rotating = true;
    }

    public void SetLeftTile(Tile tile)
    {
        leftTile = tile;
    }
    public void SetRightTile(Tile tile)
    {
        rightTile = tile;
    }

    public void SetForwardTile(Tile tile)
    {
        forwardTile = tile;
    }
    public void SetBackwardTile(Tile tile)
    {
        backwardTile = tile;
    }
    public void SetCurrentTile(Tile tile)
    {
        currentTile = tile;
    }

}
