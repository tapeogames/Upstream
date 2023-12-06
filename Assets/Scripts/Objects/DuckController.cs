using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckController : MonoBehaviour
{
    public GameObject duck;
    public PushableObjectController duckling;
    public Tile current;

    Vector3 offset = new Vector3(0, -0.5f, 0);
    public float speed = 0.2f;

    public bool moving = false;

    private void Start()
    {
        current.activate = false;
    }

    private void Update()
    {
        if (moving)
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
        current.activate = true;
    }
    void MoveTowardsWin()
    {
        GameObject obj = GameObject.FindWithTag("Win");

        if (obj != null)
        {
            Vector3 targetPosition = obj.transform.position + new Vector3(0, 0.8f, 0);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, (speed * 0.5f) * Time.deltaTime);

            if (transform.position == targetPosition)
            {
                moving = false;
                Destroy(duck);
            }
        }
    }

}

