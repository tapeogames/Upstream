using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using System;

public class PlayerController : SceneObject
{
    public GameObject playerAvatar;
    public GameObject detectors;
    public float distance;

    //public PushableObjectController pushObjectx[indexObject];
    public PushableObjectController[] pushObject;
    private SphereCollider forward;

    public static bool grabbing;
    public static bool canGrab;
    public static int indexObject;

    public Vector3 playerLookAt;
    public float speed;
    public float rotationSpeed;
    public bool grabbingBool;
    public bool moving;
    public bool rotating;
    public bool rotatingNormal;
    public Vector3 movingDirection;
    public Vector3 targetPosition;
    public float distanceToTarget;

    Quaternion rotationTarget;

    Vector2 _movement;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (grabbing) { grabbingBool = true; }
        else if (!grabbing) { grabbingBool = false; }
        Translate();
        if (moving)
        {
            PerformMovement();
        }
        if (rotating && !grabbing)
        {
            RotateTowardsDirection();
        }
        if (!moving && !grabbing && !rotating && rotatingNormal)
        {
            NormalRotateTowardsDirection();
        }

    }


    public void OnMove(InputValue input)
    {
        _movement = input.Get<Vector2>();
    }

    public void OnGrab(InputValue input)
    {
        Grab();

    }

    void Grab()
    {
        if (canGrab)
        {
            Debug.Log("index obj: " + indexObject);
            if (!pushObject[indexObject].isGrabbed)
            {
                
                playerLookAt = playerAvatar.transform.forward;
                playerLookAt.Normalize();
                pushObject[indexObject].GrabObject();
                grabbing = true;
                pushObject[indexObject].currentTile.activate = true;
            }
            else
            {
                grabbing = false;
                pushObject[indexObject].ReleaseObject();
                pushObject[indexObject].currentTile.activate = false;
                rotating = false;
            }
        }
    }

    Tile SelectTile()
    {

        Tile tile;
        if (!grabbing)
        {
            if (_movement.x > 0)
            {
                return tile = leftTile;
            }
            else if (_movement.x < 0)
            {
                return tile = rightTile;
            }
            else if (_movement.y > 0)
            {
                return tile = upTile;
            }
            else if (_movement.y < 0)
            {
                return tile = downTile;
            }
            
            return null;
        }
        else
        {
            Debug.Log("lookat: " + playerLookAt);
            
            if (Math.Abs(playerLookAt.x)>Math.Abs(playerLookAt.z))
            {
                Debug.Log("lookatX: " + playerLookAt);
                if (_movement.x > 0)
                {
                    return tile = leftTile;
                }
                else if (_movement.x < 0)
                {
                    return tile = rightTile;
                }
            }
            else 
            {
                Debug.Log("lookatZ: " + playerLookAt);
                if (_movement.y > 0)
                {
                    return tile = upTile;
                }
                else if (_movement.y < 0)
                {
                    return tile = downTile;
                }
            }
            return null;
        }
        
    }


    Tile SelectTileHack(PushableObjectController obj)
    {
        Tile tile;

        if (_movement.x > 0)
        {
            return tile = obj.leftTile;
        }
        else if (_movement.x < 0)
        {
            return tile = obj.rightTile;
        }
        else if (_movement.y > 0)
        {
            return tile = obj.upTile;
        }
        else if (_movement.y < 0)
        {
            return tile = obj.downTile;
        }

        return null;
    }

    void Translate()
    {
        var tile = SelectTile();

        if (tile == null)
            return;

        Debug.Log(_movement);
        if (!grabbing && tile.activate)
        {
            
            MoveToPosition(tile.GetTilePosition());
        }
        else if (grabbing && tile.activate && SelectTileHack(pushObject[indexObject]) != null && SelectTileHack(pushObject[indexObject]).activate)
        {
            MoveToPosition(tile.GetTilePosition());
        }
        else if (!grabbing && !tile.activate)
        {
            Debug.Log("entra");
            Vector3 turn = new Vector3(-_movement.x, 0, -_movement.y);
            Debug.Log(turn);
            StartRotation(turn);
        }

    }

    void PerformMovement()
    {
        float currentDistance = (targetPosition - transform.position).magnitude;

        if (distanceToTarget < currentDistance)
        {
            moving = false;
            transform.position = targetPosition;
        }
        else
        {
            distanceToTarget = currentDistance;
            transform.position += movingDirection * speed * Time.deltaTime;
        }
    }

    void RotateTowardsDirection()
    {
        movingDirection.Normalize();
        Quaternion targetRotation = Quaternion.LookRotation(movingDirection);
        playerAvatar.transform.rotation = Quaternion.Slerp(playerAvatar.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        float angleDifference = Quaternion.Angle(playerAvatar.transform.rotation, targetRotation);
        if (angleDifference < 0.1f)
        {
            rotating = false;
            rotatingNormal = false;
        }

    }


    void StartRotation(Vector3 v)
    {
        Debug.Log("se ejecuta v: " + v);
        Quaternion targetRotation = Quaternion.LookRotation(v);
        rotationTarget = targetRotation;
        rotatingNormal = true;
    }

    void NormalRotateTowardsDirection()
    {
        float step = rotationSpeed * Time.deltaTime;
        playerAvatar.transform.rotation = Quaternion.Slerp(playerAvatar.transform.rotation, rotationTarget, step);
        float angleDifference = Quaternion.Angle(playerAvatar.transform.rotation, rotationTarget);

        if (angleDifference < 0.1f)
        {
            rotating = false;
            rotatingNormal = false;
        }
    }

    public void MoveToPosition(Vector3 position)
    {
        targetPosition = position;
        movingDirection = (position - transform.position);
        distanceToTarget = movingDirection.magnitude;
        movingDirection = movingDirection.normalized;
        rotating = true;
        moving = true;
    }



}
