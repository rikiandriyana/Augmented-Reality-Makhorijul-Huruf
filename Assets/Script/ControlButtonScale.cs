using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlButtonScale : MonoBehaviour
{
    public Button[] buttonScale;
    Vector3 defaultScaleObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TargetFound(GameObject target) {
        for (int i = 0; i < buttonScale.Length; i++) {
            buttonScale[i].interactable = true;
        }

        HoldIncreaseScale.targetScale = target;
        defaultScaleObject = target.transform.localScale; //menyimpan scale default
    }

    public void TargetLost() {
        for (int i = 0; i < buttonScale.Length; i++) {
            buttonScale[i].interactable = false;
        }
        if (HoldIncreaseScale.targetScale != null) {
            HoldIncreaseScale.targetScale.transform.localScale = new Vector3(defaultScaleObject.x, defaultScaleObject.y, defaultScaleObject.z); // reset scale
        }
        HoldIncreaseScale.targetScale = null;
    }
}
