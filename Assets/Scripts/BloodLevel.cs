using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodLevel : MonoBehaviour
{
    public static int bloodLevel = 1;
    public static float buttonClickCooldown = 0.5f;

    private void Update() {
        if(buttonClickCooldown > 0.0f) {
            buttonClickCooldown -= Time.deltaTime;
        }
    }
}
