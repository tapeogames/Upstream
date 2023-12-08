using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool stop;
    public float timeElapsed;

    private void Awake()
    {
        stop = true;
        timeElapsed = 0;
    }

    private void Update()
    {
        if (stop)
        {
            timeElapsed+= Time.deltaTime;
        }
    }
}
