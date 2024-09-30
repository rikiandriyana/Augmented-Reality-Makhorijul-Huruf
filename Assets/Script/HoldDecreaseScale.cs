using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoldDecreaseScale : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isHold;
    public float multipleScale;
    public float minScale;

    //ui
    public Button[] buttonScale;
    GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHold == true) {
            DecreaseScaleObject();
        }
    }

    public void OnPointerDown(PointerEventData data) {
        isHold = true;
    }

    public void OnPointerUp(PointerEventData data) {
        isHold = false;
    }

    void DecreaseScaleObject() {
        targetObject = HoldIncreaseScale.targetScale;

        if (HoldIncreaseScale.targetScale.transform.localScale.x > minScale) {
            targetObject.transform.localScale = new Vector3(targetObject.transform.localScale.x - Time.deltaTime * multipleScale, targetObject.transform.localScale.y - Time.deltaTime * multipleScale, targetObject.transform.localScale.z - Time.deltaTime * multipleScale);    
            if (buttonScale[0].interactable == false) {
                buttonScale[0].interactable = true;                
            }
        } else {
            buttonScale[1].interactable = false;
        }
    }
}
