using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionsMenuManager : MonoBehaviour
{
    public TextMeshProUGUI age;
    int value;

    public void Start()
    {
        value = 0;
        age.SetText(value.ToString());
    }
   
   
    public void NextScene()
    {
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
