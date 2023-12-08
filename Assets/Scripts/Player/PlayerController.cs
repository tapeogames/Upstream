using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;
using System;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

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

    public int movementCont = 0;
    public int inputCont= 0;
    public bool canMove;
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
        //Translate();
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
        
        //Comprobaciones de teclado
        ReadInputDown();
        ReadInputUp();
    }

    public void ReadInputDown()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            inputCont++;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            inputCont++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            inputCont++;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            inputCont++;
        }
    }

    public void ReadInputUp()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            inputCont--;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            inputCont--;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            inputCont--;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            inputCont--;
        }
    }

    public void OnMove(InputValue input)
    {
        if (inputCont == 0)
        {
            _movement = input.Get<Vector2>();
            Translate();
        }
    }

    public void OnGrab(InputValue input)
    {

        Grab();

    }


    void Grab()
    {
        if (canGrab && !moving)
        {
            //Debug.Log("ha agarrado");                      
            //Debug.Log("index obj: " + indexObject);
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
            //Debug.Log("lookat: " + playerLookAt);

            if (Math.Abs(playerLookAt.x) > Math.Abs(playerLookAt.z))
            {
                //Debug.Log("lookatX: " + playerLookAt);
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
                //Debug.Log("lookatZ: " + playerLookAt);
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

        //Debug.Log(_movement);
        if (!grabbing && tile.activate)
        {
            MoveToPosition(tile.GetTilePosition());
            canMove = false;
            movementCont++;
        }
        else if (grabbing && tile.activate && SelectTileHack(pushObject[indexObject]) != null && SelectTileHack(pushObject[indexObject]).activate)
        {
            MoveToPosition(tile.GetTilePosition());
            canMove = false;
            movementCont++;
        }
        else if (!grabbing && !tile.activate)
        {
            //Debug.Log("entra");
            Vector3 turn = new Vector3(-_movement.x, 0, -_movement.y);
            Debug.Log(turn);
            StartRotation(turn);
            movementCont++;
        }
        Debug.Log("cont: " + movementCont);
    }



    void PerformMovement()
    {
        float currentDistance = (targetPosition - transform.position).magnitude;

        if (distanceToTarget < currentDistance)
        {
            if (grabbing)
            {
                //Debug.Log("can drop");
                canDrop = true;
            }
            moving = false;
            transform.position = targetPosition;
            canMove = true;
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
        //Debug.Log("moving direction: "+ movingDirection);
        movingDirection.Normalize();
        Quaternion targetRotation = Quaternion.LookRotation(movingDirection);
        //Debug.Log("target rotation "+ targetRotation);
        playerAvatar.transform.rotation = Quaternion.Slerp(playerAvatar.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                

        float angleDifference = Quaternion.Angle(playerAvatar.transform.rotation, targetRotation);
        //Debug.Log("angulo: " + angleDifference);
        
        if (angleDifference < 30f)
        {
            //playerAvatar.transform.rotation = targetRotation;
            rotationSpeed = 25;
            
        }

        if (angleDifference < 0.1f)
        {
            rotating = false;
            rotatingNormal = false;
            rotationSpeed = 4;
        }

    }

    void StartRotation(Vector3 v)
    {
        //Debug.Log("se ejecuta v: " + v);
        Quaternion targetRotation = Quaternion.LookRotation(v);
        rotationTarget = targetRotation;
        rotatingNormal = true;
    }

    void NormalRotateTowardsDirection()
    {
        float step = rotationSpeed * Time.deltaTime;
        playerAvatar.transform.rotation = Quaternion.Slerp(playerAvatar.transform.rotation, rotationTarget, step);
        float angleDifference = Quaternion.Angle(playerAvatar.transform.rotation, rotationTarget);

        if (angleDifference < 30f)
        {
            //playerAvatar.transform.rotation = targetRotation;
            rotationSpeed = 25;

        }
        if (angleDifference < 0.1f)
        {
            rotating = false;
            rotatingNormal = false;
            rotationSpeed = 5;
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
