using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class PhoneControlsManager : MonoBehaviour
{
    public GameObject movementButtons;
    public GameObject actionButton;

    [DllImport("__Internal")]
    private static extern bool IsMobile();

    private void Start()
    {
        // Verificar si se está ejecutando en un dispositivo móvil y activar/desactivar los botones según sea necesario
        if (isMobile())
        {
            ActivateMobileButtons();
        }
    }

    public bool isMobile()
    {
#if !UNITY_EDITOR && UNITY_WEBGL
        return IsMobile();
#endif
        return false;
    }

    private void ActivateMobileButtons()
    {
        // Activa los game objects correspondientes para dispositivos móviles
        if (movementButtons != null)
        {
            movementButtons.SetActive(true);
        }

        if (actionButton != null)
        {
            actionButton.SetActive(true);
        }
    }
}
