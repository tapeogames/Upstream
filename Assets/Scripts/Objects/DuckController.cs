using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{
    public GameObject duck;
    public PushableObjectController duckling;

    Vector3 offset = new Vector3 (0, 1, 0);
    public float speed = 2f;

    public bool moving = false;
    public Vector3 movingDirection = new Vector3(-7, 0, -7);

    private void Update()
    {
        if(moving) 
        {
            MoveTowardsWin();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("DucklingDetector"))
        {
            Debug.Log("tengo patito");
            GrabDuckling();
        }
    }

    public void GrabDuckling()
    {
        PlayerController.grabbing = false;
        duckling.ReleaseObject();
        duckling.transform.position = duck.transform.position + offset;

        //obj como hijo del personaje
        duckling.transform.position = duck.transform.position + offset;
        duckling.transform.rotation = duck.transform.rotation;

        //obj como hijo del personaje
        duckling.transform.parent = duck.transform;

        LeaveScene();
    }

    public void LeaveScene()
    {
        moving = true;
    }
    void MoveTowardsWin()
    {
        GameObject obj = GameObject.FindWithTag("Win");

        if (obj != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, obj.transform.position + movingDirection, speed * Time.deltaTime);

            if (transform.position == obj.transform.position + movingDirection)
            {
                moving = false;
            }
        }
    }

}

