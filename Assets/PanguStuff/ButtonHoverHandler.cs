using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHoverHandler : MonoBehaviour
{
    public GameObject hoverEffect;
    public float localScaleX, localScaleY, localPosX, localPosY;
    private GameObject hoverEffectTemp;
    private bool pointerDown;

    void Start() {
        pointerDown = false;
    }

    public void onMouseOver() {
        if (!pointerDown) {
            hoverEffectTemp = Instantiate(hoverEffect, new Vector3(0, 0, 0), Quaternion.identity);
            hoverEffectTemp.transform.parent = gameObject.transform;
            hoverEffectTemp.transform.localScale = new Vector3(localScaleX, localScaleY, 1);
            hoverEffectTemp.transform.localPosition = new Vector3(localPosX, localPosY, 0);        
        }
    }

    public void onPointerDown() {
        Debug.Log("ee");
        pointerDown = true;
        Destroy(hoverEffectTemp);
    }

    public void onPointerUp() {
        pointerDown = false;
    }

    public void onMouseOut() {
        Destroy(hoverEffectTemp);
    }

    public void deleteHoverEffect() {
        Destroy(hoverEffectTemp);
    }
}
