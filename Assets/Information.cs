using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Information : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text;
    public WinCondition winCondition;
    private void Update()
    {
        if (winCondition.winLevel)
        {
            string tS = "<size=80>"+winCondition.timeString+"</size>";
            string mS = "<size=60>"+winCondition.movementString+"</size>";

            text.text = "¡Has hecho "+ mS + " movimientos! \n" + tS;


        }
    }
}
