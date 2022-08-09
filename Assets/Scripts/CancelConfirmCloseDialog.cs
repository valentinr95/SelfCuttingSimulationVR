using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelConfirmCloseDialog : MonoBehaviour
{

    public GameObject OptionsWindow;
    public GameObject ConfirmCloseDialog;

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        ConfirmCloseDialog.SetActive(false);
        OptionsWindow.SetActive(true);
    }
}
