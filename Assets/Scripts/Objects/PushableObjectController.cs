using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PushableObjectController : SceneObject
{
    private GameObject pushableObject;
    public PlayerController playerController;
    public int index;

    public bool isGrabbed = false;
    public bool isTriggered = false;
    public Vector3 offset;

    public bool moving = false;
    public Vector3 movingDirection;
    public Vector3 targetPosition;
    public float distanceToTarget;

    // Start is called before the first frame update
    void Start()
    {
        pushableObject = sceneObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
        }
        if (other.CompareTag("ForwardPlayer"))
        {
            PlayerController.indexObject = index;
            PlayerController.canGrab = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //deactivate = true;
            isTriggered = false;
        }
        if (other.CompareTag("ForwardPlayer"))
        {
            PlayerController.canGrab = false;
        }

    }


    public void GrabObject()
    {

        if(isTriggered)
        {
            isGrabbed = true;

            offset = pushableObject.transform.position - playerController.transform.position;
            pushableObject.transform.position = playerController.transform.position + offset;

            //obj como hijo del personaje
            pushableObject.transform.parent = playerController.transform;

        }               

    }

    public void ReleaseObject()
    {
        if (isGrabbed)
        {
            
            isGrabbed = false;

            //resetea padre
            pushableObject.transform.parent = null;
        }
    }

}
