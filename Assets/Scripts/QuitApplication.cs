using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        Application.Quit();
    }
}
