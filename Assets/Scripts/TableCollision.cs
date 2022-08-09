using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCollision : MonoBehaviour
{
    
    public GameObject leftHand;
    public GameObject leftKnifeHandle;
    public GameObject leftKnifeBlade;
    public GameObject rightHand;
    public GameObject rightKnifeHandle;
    public GameObject rightKnifeBlade;
    public GameObject knifeParent;

    void Start()
    {
        Physics.IgnoreCollision(leftHand.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        Physics.IgnoreCollision(leftKnifeHandle.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        Physics.IgnoreCollision(leftKnifeBlade.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        Physics.IgnoreCollision(rightHand.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        Physics.IgnoreCollision(rightKnifeHandle.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        Physics.IgnoreCollision(rightKnifeBlade.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
        Physics.IgnoreCollision(knifeParent.GetComponent<Collider>(), gameObject.GetComponent<Collider>());
    }

}
