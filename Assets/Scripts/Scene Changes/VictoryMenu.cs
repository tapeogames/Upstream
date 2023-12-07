using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public int numeroEscena;
    public void Exit()
    {
        StartCoroutine(DelayedExit());
    }
    public void SiguienteNivel(int numEscena)
    {
        StartCoroutine(DelayedSiguienteNivel(numEscena));
    }

    private IEnumerator DelayedExit()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(3);
    }
    private IEnumerator DelayedSiguienteNivel(int numEscena)
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(numEscena + 1);
    }
}
