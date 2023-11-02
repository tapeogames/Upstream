using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagmite : Tile
{

    //public static int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ObjectDetector") && PlayerController.grabbing)
        {
            Debug.Log("HOLAA");
            activateObject = false;
            activatePlayer = true;


        } 
    }





}
