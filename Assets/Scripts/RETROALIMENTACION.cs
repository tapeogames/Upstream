using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RETROALIMENTACION : MonoBehaviour
{
    public GameObject normal;
    public GameObject retroalimentacion;
    public bool estado = true;

    void Update()
    {
        if(estado == true && Input.GetKeyDown(KeyCode.Space))
        {
            normal.SetActive(false);
            retroalimentacion.SetActive(true);
            estado = false;
        }
        else if(estado == false && Input.GetKeyDown(KeyCode.Space))
        {
            normal.SetActive(true);
            retroalimentacion.SetActive(false);
            estado = true;
        }
    }
}
