using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectScale : MonoBehaviour
{
    public Button[] buttonScales;
    public float increaseScale, decreaseScale;
    public float maxScale, minScale;
    GameObject targetScale;
    Vector3 defaultScale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonScaleActive(GameObject objectScale) { //target found
        for (int i = 0; i < buttonScales.Length; i++)
        {
            buttonScales[i].interactable = true;   
        }

        targetScale = objectScale;
        defaultScale = targetScale.transform.localScale; //menyimpan scale
    } 

    public void ButtonScaleOff() { //target loss
        for (int i = 0; i < buttonScales.Length; i++)
        {
            buttonScales[i].interactable = false;
        }

        if (targetScale != null) {
            targetScale.transform.localScale = new Vector3(defaultScale.x, defaultScale.y, defaultScale.z); // reset scale
        }
        targetScale = null;
    }
    public void ButtonIncreaseScale() {
        if (targetScale.transform.localScale.x < maxScale) {
            targetScale.transform.localScale = new Vector3(targetScale.transform.localScale.x + increaseScale, targetScale.transform.localScale.y + increaseScale, targetScale.transform.localScale.z + increaseScale);   
            if (buttonScales[1].interactable == false) {
                buttonScales[1].interactable = true;
            }
        } if (targetScale.transform.localScale.x >= maxScale) {
            targetScale.transform.localScale = new Vector3(maxScale, maxScale, maxScale);
            buttonScales[0].interactable = false;
        }
    }

    public void ButtonDecreaseScale() {
        if (targetScale.transform.localScale.x > minScale) {
            targetScale.transform.localScale = new Vector3(targetScale.transform.localScale.x - decreaseScale, targetScale.transform.localScale.y - decreaseScale, targetScale.transform.localScale.z - decreaseScale);
            if (buttonScales[0].interactable == false) {
                buttonScales[0].interactable = true;
            }
        } if (targetScale.transform.localScale.x <= minScale){
            targetScale.transform.localScale = new Vector3(minScale, minScale, minScale);
            buttonScales[1].interactable = false;
        }
    }
}
