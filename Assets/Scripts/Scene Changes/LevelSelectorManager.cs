using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorManager : MonoBehaviour
{
    //inician las corutinas para dar tiempo al sonido del boton antes de cambiar de escena
    public void Return()
    {
        StartCoroutine(DelayedReturn());
    }

    public void Level0()
    {
        // OJO: le lleva a la cinemática, luego desde la cinemática ya va al nivel 0
        StartCoroutine(DelayedLevel0());
    }

    public void Level1()
    {
        StartCoroutine(DelayedLevel1());
    }

    public void Level2()
    {
        StartCoroutine(DelayedLevel2());
    }

    public void Level3()
    {
        StartCoroutine(DelayedLevel3());
    }

    public void Level4()
    {
        StartCoroutine(DelayedLevel4());
    }

    public void Level5()
    {
        StartCoroutine(DelayedLevel5());
    }

    public void Level6()
    {
        StartCoroutine(DelayedLevel6());
    }

    public void Level7()
    {
        StartCoroutine(DelayedLevel7());
    }

    public void Level8()
    {
        StartCoroutine(DelayedLevel8());
    }

    public void Level9()
    {
        StartCoroutine(DelayedLevel9());
    }

    public void Level10()
    {
        StartCoroutine(DelayedLevel10());
    }

    public void Level11()
    {
        StartCoroutine(DelayedLevel11());
    }

    public void Level12()
    {
        StartCoroutine(DelayedLevel12());
    }

    public void Level13()
    {
        StartCoroutine(DelayedLevel13());
    }
    //Funciones con delay para que suenen los botones

    private IEnumerator DelayedReturn()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(2);
    }
    private IEnumerator DelayedLevel0()
    {
        // OJO: le lleva a la cinemática, luego desde la cinemática ya va al nivel 0
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(5);
    }

    private IEnumerator DelayedLevel1()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(7);
    }

    private IEnumerator DelayedLevel2()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(8);
    }

    private IEnumerator DelayedLevel3()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(9);
    }

    private IEnumerator DelayedLevel4()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(10);
    }

    private IEnumerator DelayedLevel5()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(11);
    }

    private IEnumerator DelayedLevel6()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(12);
    }

    private IEnumerator DelayedLevel7()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(13);
    }

    private IEnumerator DelayedLevel8()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(14);
    }

    private IEnumerator DelayedLevel9()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(15);
    }

    private IEnumerator DelayedLevel10()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(16);
    }

    private IEnumerator DelayedLevel11()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(17);
    }

    private IEnumerator DelayedLevel12()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(18);
    }

    private IEnumerator DelayedLevel13()
    {
        yield return new WaitForSeconds((float)0.3);
        SceneManager.LoadScene(19);
    }
}
