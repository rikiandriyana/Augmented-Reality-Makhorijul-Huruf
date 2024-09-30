using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderRotate : MonoBehaviour
{
    public Slider sliderRotateObject;
    GameObject targetRotate;
    // public float rotateLimit; //90 100 360
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void RotateObject() {
    //     targetRotate.transform.localEulerAngles = new Vector3(0f, - sliderRotateObject.value * rotateLimit ,0f);
    // }

    public void TargetFound(GameObject target) {
        sliderRotateObject.interactable = true; //mengaktifkan ui slider

        targetRotate = target;
    }

    public void TargetLost() {
        sliderRotateObject.interactable = false; //mematikan ui slider

        sliderRotateObject.value = 0;

        if (targetRotate != null) {
            // targetRotate.transform.localEulerAngles = Vector3.zero; //new vector3 (0f,0f,0f);
            targetRotate.transform.localEulerAngles = new Vector3(-90f, 180f, 0f);
        }

        targetRotate = null;
    }
}
