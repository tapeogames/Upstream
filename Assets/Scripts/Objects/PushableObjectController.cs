using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PushableObjectController : SceneObject
{
    public GameObject pushableObject;
    public PlayerController playerController;
    public int index;

    public bool isGrabbed = false;
    public bool isTriggered = false;
    public Vector3 offset;

    public bool moving = false;
    public Vector3 movingDirection;
    public Vector3 targetPosition;
    public float distanceToTarget;
    public GameObject tutorial0;

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
            tutorial0.SetActive(true);
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
            tutorial0.SetActive(false);
        }

    }


    public void GrabObject()
    {

        if (isTriggered)
        {
            isGrabbed = true;

            offset = pushableObject.transform.position - playerController.transform.position;
            pushableObject.transform.position = playerController.transform.position + offset;
            pushableObject.transform.rotation = playerController.transform.rotation;

            //obj como hijo del personaje
            pushableObject.transform.parent = playerController.transform;

        }

    }

    public void ReleaseObject()
    {
        if (isGrabbed)
        {
            if(pushableObject.tag != ("DucklingDetector"))
            {
                AproximateTile();
            }
            isGrabbed = false;

            //resetea padre
            pushableObject.transform.parent = null;
        }
    }

    public void AproximateTile()
    {        
        Debug.Log("APROXIMADO");
        pushableObject.transform.position = new Vector3( 
            currentTile.transform.position.x,
            pushableObject.transform.position.y, 
            currentTile.transform.position.z);
    }

}
