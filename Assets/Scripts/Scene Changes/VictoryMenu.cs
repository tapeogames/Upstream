using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public int numeroEscena;
    public void Exit()
    {
        SceneManager.LoadScene(3);
    }
    public void SiguienteNivel(int numEscena)
    {
        SceneManager.LoadScene(numEscena+1);
    }
}
