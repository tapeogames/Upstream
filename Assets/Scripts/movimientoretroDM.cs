using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoretroDM : MonoBehaviour
{
    public GameObject personaje; // Asigna el GameObject del personaje desde el Inspector
    public GameObject imagen; // Asigna el GameObject de la imagen desde el Inspector
    public bool frente = true;
    public bool derecha = false;
    public bool izquierda = false;
    public bool atras = false;
    bool imagenVisible = false;
    Vector3 offset;

    void Update()
    {
        // Controlar la aparición de la imagen al presionar la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            imagenVisible = !imagenVisible;
            imagen.SetActive(imagenVisible);
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

        if (personaje != null && imagen != null && imagenVisible)
        {
            // Obtener la posición del personaje
            Vector3 posicionPersonaje = personaje.transform.position;

            if (frente)
            {
                // Definir la posición de la imagen a un offset del personaje
                offset = new Vector3(0.27f, 1.6f, 0.3f); // Ajusta el offset como desees
            }
            if (derecha)
            {
                offset = new Vector3(-0.0f, 1.3f, 0.25f);
            }
            if (izquierda)
            {
                offset = new Vector3(0.05f, 1.3f, 0.25f);
            }
            if (atras)
            {
                offset = new Vector3(-0.23f, 1.4f, 0.2f);
            }


            // Asignar la posición de la imagen en relación al personaje
            imagen.transform.position = posicionPersonaje + offset;
        }
    }
}