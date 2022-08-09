using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PaintIn3D;

public class ChangeSkinColorClick : MonoBehaviour
{

    private P3dMaterialCloner p3dMaterialCloner;

    public GameObject leftArm;
    public GameObject leftArmWithKnife;

    public GameObject rightArm;
    public GameObject rightArmWithKnife;

    public MaterialList[] materialList;

    private int currentIndex = 0;

    private void OnCollisionEnter(UnityEngine.Collision collisionInfo) {
        if(CanvasButtonCooldown.buttonClickCooldown < 0.0f) {
            CanvasButtonCooldown.buttonClickCooldown = 2.0f;  


            // deactivates cloner and P3dPaintableTexture
            leftArm.GetComponent<P3dPaintable>().Deactivate();
            rightArm.GetComponent<P3dPaintable>().Deactivate();

            leftArm.GetComponent<SkinnedMeshRenderer>().materials = materialList[currentIndex].materials;
            var paintableTextures = leftArm.GetComponents<P3dPaintableTexture>();
            for(int i = 0; i < 2; ++i) {
                string textureName = paintableTextures[i].Texture.ToString();
                if (textureName.Contains("Normal")) {
                    paintableTextures[i].Texture = leftArm.GetComponent<SkinnedMeshRenderer>().materials[1].GetTexture("_BumpMap");
                } else if (textureName.Contains("Albedo")) {
                    paintableTextures[i].Texture = leftArm.GetComponent<SkinnedMeshRenderer>().materials[1].mainTexture;
                }
            } 

            leftArmWithKnife.GetComponent<SkinnedMeshRenderer>().materials = materialList[currentIndex].materials;

            rightArm.GetComponent<SkinnedMeshRenderer>().materials = materialList[currentIndex].materials;
            var paintableTexturesNew = rightArm.GetComponents<P3dPaintableTexture>();
            for(int i = 0; i < 2; ++i) {
                string textureName = paintableTexturesNew[i].Texture.ToString();
                if (textureName.Contains("Normal")) {
                    paintableTexturesNew[i].Texture = rightArm.GetComponent<SkinnedMeshRenderer>().materials[1].GetTexture("_BumpMap");
                } else if (textureName.Contains("Albedo")) {
                    paintableTexturesNew[i].Texture = rightArm.GetComponent<SkinnedMeshRenderer>().materials[1].mainTexture;
                }
            }


            rightArmWithKnife.GetComponent<SkinnedMeshRenderer>().materials = materialList[currentIndex].materials;
            
            // activates cloner and P3dPaintableTexture
            leftArm.GetComponent<P3dPaintable>().Activate();
            rightArm.GetComponent<P3dPaintable>().Activate();



            if(currentIndex == materialList.Length - 1) {
                currentIndex = 0;
            } else {
                ++currentIndex;
            }
                
        }
    }
}
