using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoretro : MonoBehaviour
{
    public GameObject personaje; // Asigna el GameObject del personaje desde el Inspector
    public bool frente = true;
    public bool derecha = false;
    public bool izquierda = false;
    public bool atras = false;
    Vector3 offset;
    public GameObject referencia;

    void Update()
    {
        // Controlar la aparición de la imagen al presionar la barra espaciadora
        if (referencia.activeInHierarchy)
        {
            
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            atras = true;
            frente = false;
            derecha = false;
            izquierda = false;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            atras = false;
            frente = true;
            derecha = false;
            izquierda = false;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            atras = false;
            frente = false;
            derecha = true;
            izquierda = false;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            atras = false;
            frente = false;
            derecha = false;
            izquierda = true;
        }

        if (personaje != null && referencia.activeInHierarchy)
        {
            // Obtener la posición del personaje
            Vector3 posicionPersonaje = personaje.transform.position;

            if (frente)
            {
                // Definir la posición de la imagen a un offset del personaje
                offset = new Vector3(0.2f, 0.6f, 0.4f); // Ajusta el offset como desees
            }
            if (derecha)
            {
                offset = new Vector3(0.0f, 0.45f, 0.4f);
            }
            if (izquierda)
            {
                offset = new Vector3(-0.0f, 0.45f, 0.4f);
            }
            if (atras)
            {
                offset = new Vector3(0.2f, 0.6f, 0.4f);
            }

            

            // Asignar la posición de la imagen en relación al personaje
            referencia.transform.position = posicionPersonaje + offset;
        }
    }
}