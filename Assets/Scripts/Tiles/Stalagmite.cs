using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagmite : Tile
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetector") && PlayerController.grabbing)
        {
            Debug.Log("HOLAA");


        } 
    }

}
