using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool activatePlayer = true;
    public bool activateObject = true;
    public BoxCollider tileCenter;
    

    void Start()
    {
        tileCenter = GetComponent<BoxCollider>();
        tileCenter.name = "tileCenter";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 GetTilePosition()
    {
        return (Vector3.right*transform.position.x+Vector3.forward*transform.position.z);
    }

    



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent") && !PlayerController.grabbing)
        {
            activatePlayer = false;
            activateObject = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ObjectDetectorCurrent"))
        {
            activatePlayer = true;
            activateObject = true;
        }
    }
}
