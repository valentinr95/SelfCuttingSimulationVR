using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKnife : MonoBehaviour
{
    public GameObject armLeft;
    public GameObject armLeftKnife;
    public GameObject armRight;
    public GameObject armRightKnife;
    public GameObject knife;


    [SerializeField]
    private float pickUpCooldown;

    private void Update() {
        if(pickUpCooldown > 0.0f) {
            pickUpCooldown -= Time.deltaTime;
        }
    }

    void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        if(pickUpCooldown > 0.0f) {
            return;
        }
        
        if(collisionInfo.gameObject.name == "L_Arm" && knife.activeSelf) {
            pickUpCooldown = 1.0f;
            HandStatus.leftHandActive = false;
            HandStatus.leftHandWithKnifeActive = true;
            armLeft.SetActive(false);
            knife.SetActive(false);
            armLeftKnife.SetActive(true);
        } else if(collisionInfo.gameObject.name == "blade_left") {
            pickUpCooldown = 1.0f;
            HandStatus.leftHandActive = true;
            HandStatus.leftHandWithKnifeActive = false;
            armLeftKnife.SetActive(false);
            armLeft.SetActive(true);
            knife.SetActive(true);
        } else if(collisionInfo.gameObject.name == "R_Arm" && knife.activeSelf) {
            pickUpCooldown = 1.0f;
            HandStatus.rightHandActive = false;
            HandStatus.rightHandWithKnifeActive = true;
            armRight.SetActive(false);
            knife.SetActive(false);
            armRightKnife.SetActive(true);
        } else if(collisionInfo.gameObject.name == "blade_right") {
            pickUpCooldown = 1.0f;
            HandStatus.rightHandActive = true;
            HandStatus.rightHandWithKnifeActive = false;
            armRightKnife.SetActive(false);
            armRight.SetActive(true);
            knife.SetActive(true);
        }
    }
}
