using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorManager : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene(2);
    }
    public void Level0()
    {
        SceneManager.LoadScene(5);
    }
    public void Level1()
    {
        SceneManager.LoadScene(6);
    }
}
