using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using System;
using UnityEngine.InputSystem;

public class PlayerController : SceneObject
{
    public GameObject playerAvatar;
    public GameObject detectors;
    public float distance;

    public PushableObjectController[] pushObject;
    private SphereCollider forward;

    public static bool grabbing;
    public static bool canGrab;
    public bool canDrop = false;
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
    public GameObject normal;
    public GameObject retroalimentacion;
    public GameObject imagen;
    public bool estado = true;

    Quaternion rotationTarget;
    Vector2 _movement;

    void Start()
    {

    }

    /*public void OnClickD()
    {
        Debug.Log("D");
        if (!grabbing && leftTile != null && leftTile.activate)
        {
            MoveToPosition(leftTile.GetTilePosition());
        }
        else if (grabbing && leftTile.activate && pushObject[indexObject].leftTile != null && pushObject[indexObject].leftTile.activate)
        {
            if (Vector3.Distance(playerLookAt, xNeg) < 0.05f || Vector3.Distance(playerLookAt, xPos) < 0.05f)
            {
                MoveToPosition(leftTile.GetTilePosition());
            }
        }
        else if (leftTile == null || !leftTile.activate)
        {
            StartRotation(xNeg);
        }
    }

    public void OnClickA()
    {
        Debug.Log("A");
        if (!grabbing && rightTile != null && rightTile.activate)
        {
            MoveToPosition(rightTile.GetTilePosition());
        }
        else if (grabbing && rightTile.activate && pushObject[indexObject].rightTile != null && pushObject[indexObject].rightTile.activate)
        {
            if (Vector3.Distance(playerLookAt, xNeg) < 0.05f || Vector3.Distance(playerLookAt, xPos) < 0.05f)
            {
                MoveToPosition(rightTile.GetTilePosition());
            }
        }
        else if (rightTile == null || !rightTile.activate)
        {
            //Debug.Log("ha entrado rigth");
            StartRotation(xPos);

        }
    }
    public void OnClickS()
    {
        Debug.Log("S");
        if (!grabbing && downTile != null && downTile.activate)
        {
            MoveToPosition(downTile.GetTilePosition());
        }
        else if (grabbing && downTile.activate && pushObject[indexObject].downTile != null && pushObject[indexObject].downTile.activate)
        {
            if (Vector3.Distance(playerLookAt, zNeg) < 0.05f || Vector3.Distance(playerLookAt, zPos) < 0.05f)
            {
                MoveToPosition(downTile.GetTilePosition());
            }
        }
        else if (downTile == null || !downTile.activate)
        {
            //Debug.Log("ha entrado forward");
            StartRotation(zPos);

        }
    }

    public void OnClickW()
    {
        Debug.Log("W");
        if (!grabbing && upTile != null && upTile.activate)
        {
            MoveToPosition(upTile.GetTilePosition());
        }
        else if (grabbing && upTile.activate && pushObject[indexObject].upTile != null && pushObject[indexObject].upTile.activate)
        {
            if (Vector3.Distance(playerLookAt, zNeg) < 0.05f || Vector3.Distance(playerLookAt, zPos) < 0.05f)
            {
                MoveToPosition(upTile.GetTilePosition());
            }
        }
        else if (upTile == null || !upTile.activate)
        {
            //Debug.Log("ha entrado backward");
            StartRotation(zNeg);

        }
    }

    public void OnClickSpace()
    {
        Debug.Log("SPACE");
        if (canGrab)
        {
            Debug.Log("index obj: " + indexObject);
            if (!pushObject[indexObject].isGrabbed)
            {
                playerLookAt = playerAvatar.transform.forward;
                playerLookAt.Normalize();
                //Debug.Log(playerLookAt);
                pushObject[indexObject].GrabObject();
                grabbing = true;
                pushObject[indexObject].currentTile.activate = true;
            }
            else
            {
                grabbing = false;
                pushObject[indexObject].ReleaseObject();
                pushObject[indexObject].currentTile.activate = false;

            }

        }
    }*/

    public void restartGame()
    {
        moving = false;
        grabbing = false;
        estado = true;
        rotating = false;
        rotatingNormal = false;
    }

    void Update()
    {
        if (grabbing) { grabbingBool = true; canDrop = true; }
        else if (!grabbing) { grabbingBool = false; canDrop = false; }
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

        if (grabbing && estado)
        {
            normal.SetActive(false);
            retroalimentacion.SetActive(true);
            imagen.SetActive(true);
            estado = false;
        }
        else if (!grabbing && !estado)
        {
            normal.SetActive(true);
            retroalimentacion.SetActive(false);
            imagen.SetActive(false);
            estado = true;
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
        if (canGrab && !moving)
        {
            Debug.Log("ha agarrado");                      
            Debug.Log("index obj: " + indexObject);
            if (!pushObject[indexObject].isGrabbed)
            {

                playerLookAt = playerAvatar.transform.forward;
                playerLookAt.Normalize();
                pushObject[indexObject].GrabObject();
                grabbing = true;
                pushObject[indexObject].currentTile.activate = true;
            }
            
        } 

        if (canDrop && !moving)
        {
            if (pushObject[indexObject].isGrabbed)
            {
                grabbing = false;
                pushObject[indexObject].ReleaseObject();
                pushObject[indexObject].currentTile.activate = false;
                rotating = false;
                canDrop= false;
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

            if (Math.Abs(playerLookAt.x) > Math.Abs(playerLookAt.z))
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
            if (grabbing)
            {
                Debug.Log("can drop");
                canDrop = true;
            }
            moving = false;
            transform.position = targetPosition;
        }
        else
        {
            if (grabbing)
            {
                canDrop = false;
            }
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
