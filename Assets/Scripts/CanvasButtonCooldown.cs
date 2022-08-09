using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasButtonCooldown : MonoBehaviour
{
    public static float buttonClickCooldown = 1.5f;

    private void Update() {
        if(buttonClickCooldown > 0.0f) {
            buttonClickCooldown -= Time.deltaTime;
        }
    }
}
