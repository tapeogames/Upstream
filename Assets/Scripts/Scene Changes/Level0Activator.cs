using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level0Activator : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene(6);
    }
}
