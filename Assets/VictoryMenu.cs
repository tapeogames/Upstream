using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene(3);
    }
    public void SiguienteNivel()
    {
        SceneManager.LoadScene(6);
    }
}
