/******************************************************************************
 * Copyright (C) Ultraleap, Inc. 2011-2021.                                   *
 *                                                                            *
 * Use subject to the terms of the Apache License 2.0 available at            *
 * http://www.apache.org/licenses/LICENSE-2.0, or another agreement           *
 * between Ultraleap and you, your company or other organization.             *
 ******************************************************************************/

using UnityEngine;

namespace Leap.Unity
{
    public class HandEnableDisableAdapted : HandTransitionBehavior
    {

        public GameObject leftHand;
        public GameObject leftHandWithKnife;
        public GameObject rightHand;
        public GameObject rightHandWithKnife;

        public static bool leftHandWithKnifeActivated = false;
        public static bool rightHandWithKnifeActivated = false;

        protected override void Awake()
        {
            // Suppress Warnings Related to Kinematic Rigidbodies not supporting Continuous Collision Detection
#if UNITY_2018_3_OR_NEWER
            Rigidbody[] bodies = GetComponentsInChildren<Rigidbody>();
            foreach (Rigidbody body in bodies)
            {
                if (body.isKinematic && body.collisionDetectionMode == CollisionDetectionMode.Continuous)
                {
                    body.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
                }
            }
#endif

            base.Awake();
        }

        // called when hand appears
        protected override void HandReset()
        {
            if(HandStatus.leftHandActive && gameObject == leftHand ) {
                gameObject.SetActive(true);
            } else if(HandStatus.leftHandWithKnifeActive && gameObject == leftHandWithKnife) {
                gameObject.SetActive(true);
            } 

            if(HandStatus.rightHandActive && gameObject == rightHand) {
                gameObject.SetActive(true);
            } else if(HandStatus.rightHandWithKnifeActive && gameObject == rightHandWithKnife) {
                gameObject.SetActive(true);
            }

            
        }

        // called when hand disappears (not on knife switch)
        protected override void HandFinish()
        {
            gameObject.SetActive(false);
        }

    }
}
