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

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("ObjectDetector") && PlayerController.grabbing)
        {
            Debug.Log("estoy dentro");
            other.GetComponentInParent<PushableObjectController>().ReleaseObject();
            other.GetComponentInParent<PushableObjectController>().currentTile.activate=false;
            PlayerController.grabbing= false;
            // esto no esta bien, pero es una opcion buscar q suelte el objeto automaticamente al entrar en la estalagmita.
            //Estoy intentando buscar la manera de q solamente pueda pasar al soltar, pero no se cómo, dale un repassillo luna 
            //he creado una clase estalagmita que hereda de tile, pero estoy planteando en hacer una nueva clase distinta
            //no se como hacer para que el collider capte dos colisiones
            
        } 
    }



}
