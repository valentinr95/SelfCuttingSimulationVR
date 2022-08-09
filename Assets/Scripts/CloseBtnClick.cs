using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBtnClick : MonoBehaviour
{
    public GameObject optionsWindow;
    public GameObject knifeParent;
    public GameObject optionsClipboard;

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        optionsWindow.SetActive(false);
        knifeParent.SetActive(true);
        optionsClipboard.SetActive(true);
    }
}
