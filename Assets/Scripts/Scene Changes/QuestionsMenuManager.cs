using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

public class QuestionsMenuManager : MonoBehaviour
{
    public TextMeshProUGUI age;
    public Button continueButton;
    public Button chico;
    public Button chica;
    public Button otro;
    public Sprite pressed;
    public Sprite normal;
    public string gender = "x";
    public int value;

    public bool send = false;

    public void Start()
    {
        value = 0;
        continueButton.interactable = false;
        age.SetText(value.ToString());

    }
    public void Update()
    {
        if(gender != "x")
        {
            continueButton.interactable = true;
            Image imagenBotonChico = chico.GetComponent<Image>();
            Image imagenBotonChica = chica.GetComponent<Image>();
            Image imagenBotonOtro = otro.GetComponent<Image>();


            if (gender == "Chico")
            {
                
                imagenBotonChico.sprite = pressed;
                imagenBotonChica.sprite = normal;
                imagenBotonOtro.sprite = normal;
            }
            else if(gender == "Chica")
            {

                
                imagenBotonChico.sprite = normal;
                imagenBotonOtro.sprite = normal;
                imagenBotonChica.sprite = pressed;
            }
            else
            {

                imagenBotonChico.sprite = normal;
                imagenBotonChica.sprite = normal;
              
                imagenBotonOtro.sprite = pressed;
            }


        }

        
    }

    public void Male()
    {
        gender = "Chico";
    }
    public void Female()
    {
        gender = "Chica";
    }
    public void Other()
    {
        gender = "Otro";
    }

    public void NextScene()
    {
        send = true;
        StartCoroutine(DelayedNextScene());
    }
    private IEnumerator DelayedNextScene()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(2);
    }
   
    public void Suma()
    {
        value++;
        age.SetText(value.ToString());
    }

    public void Resta()
    {
        if(value > 0)
        {
            value--;
        }
        age.SetText(value.ToString());
    }
}
