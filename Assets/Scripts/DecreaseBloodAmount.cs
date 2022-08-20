using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreaseBloodAmount : MonoBehaviour
{
    public GameObject bloodEffect;
    public Text bloodAmountDisplay;

    private const float bloodDecreaseValue = 0.001f;

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        if(BloodLevel.buttonClickCooldown < 0.0f && BloodLevel.bloodLevel > 1) {
            bloodEffect.GetComponent<PaintIn3D.P3dPaintDecal>().Radius -= bloodDecreaseValue;
            BloodLevel.bloodLevel--;
            bloodAmountDisplay.text = BloodLevel.bloodLevel.ToString();
        }
        BloodLevel.buttonClickCooldown = 0.5f;
    }
}
