using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOptions : MonoBehaviour
{

    public GameObject optionsCanvas;
    public GameObject optionsClipboard;
    public GameObject armLeft;
    public GameObject armRight;
    public GameObject knifeParent;


    void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        if((collisionInfo.gameObject == armLeft && !optionsCanvas.activeSelf) || (collisionInfo.gameObject == armRight && !optionsCanvas.activeSelf)) {
            optionsCanvas.SetActive(true);
            optionsClipboard.SetActive(false);
            gameObject.SetActive(false);
            knifeParent.SetActive(false);
        }
    }
}
