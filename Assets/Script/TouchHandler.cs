using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour
{
    public GameObject touchArea; // Assign the TouchArea game object in the Inspector
    private Renderer touchAreaRenderer;

    void Start()
    {
        if (touchArea != null)
        {
            touchAreaRenderer = touchArea.GetComponent<Renderer>();
        }
        else
        {
            Debug.LogError("TouchArea is not assigned.");
        }
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == "Makhorijul Huruf Gigi") // Make sure it matches the name of your TouchArea GameObject
                    {
                        OnVirtualButtonPressed();
                    }
                }
            }
        }
    }

    void OnVirtualButtonPressed()
    {
        Debug.Log("Virtual Button Pressed");

        // Contoh logika sederhana: mengubah warna objek
        if (touchAreaRenderer != null)
        {
            touchAreaRenderer.material.color = Random.ColorHSV();
        }
    }
}
