using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenConfirmCloseDialog : MonoBehaviour
{

    public GameObject optionsWindow;
    public GameObject confirmCloseCanvas;

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        optionsWindow.SetActive(false);
        confirmCloseCanvas.SetActive(true);
    }
}
