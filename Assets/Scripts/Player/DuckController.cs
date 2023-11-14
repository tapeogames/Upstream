using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : SceneObject
{
    public GameObject duck;
    public PushableObjectController duckling;

    public bool isNear = false;

    public bool moving = false;
    public Vector3 movingDirection;
    public Vector3 targetPosition;
    public float distanceToTarget;

    // Start is called before the first frame update
    void Start()
    {
        duck = sceneObject;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

        }
    }

    public void GrabDuckling()
    {

        if (isNear)
        {
            duckling.transform.position = duck.transform.position;

            //obj como hijo del personaje
            duckling.transform.parent = duck.transform;

        }

    }

    public void LeaveScene()
    {
        
    }

}
