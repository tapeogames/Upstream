using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool activate = true;
    public BoxCollider tileCenter;
    

    void Start()
    {
        tileCenter = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (activate == false)
        {
            tileCenter.enabled = false;
        }
        else
        {
            tileCenter.enabled = true;
        }*/
    }

    public Vector3 GetTilePosition()
    {
        return (Vector3.right*transform.position.x+Vector3.forward*transform.position.z);
    }

    



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetector") && !PlayerController.grabbing)
        {
            activate = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetector"))
        {
            activate = true;
        }
    }
}
