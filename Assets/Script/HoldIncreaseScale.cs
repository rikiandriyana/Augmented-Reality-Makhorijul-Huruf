using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoldIncreaseScale : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isHold;
    public float multipleScale;
    public float maxScale;
    public static GameObject targetScale;

    // ui
    public Button[] buttonScales;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHold == true) {
            IncreaseScaleObject();
        }
    }
    
    public void OnPointerDown(PointerEventData data) {
        isHold = true;
    }
    
    public void OnPointerUp(PointerEventData data) {
        isHold = false;
    }

    void IncreaseScaleObject() {
        if (targetScale.transform.localScale.x < maxScale) {
            targetScale.transform.localScale = new Vector3(targetScale.transform.localScale.x + Time.deltaTime * multipleScale, targetScale.transform.localScale.y + Time.deltaTime * multipleScale, targetScale.transform.localScale.z + Time.deltaTime * multipleScale);
            if (buttonScales[1].interactable == false) {
                buttonScales[1].interactable = true;
            }
        } else {
            // turn off button increase
            buttonScales[0].interactable = false;
        }
    }
}
