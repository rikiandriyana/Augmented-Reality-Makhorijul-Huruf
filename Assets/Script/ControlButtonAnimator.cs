using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlButtonAnimator : MonoBehaviour
{
    public Button[] buttonControls; //0 pause 1 play 2 stop
    GameObject targetControlAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPauseAnimation() {
        Time.timeScale = 0; //pause frame
        buttonControls[0].interactable = false; //button pause deactive
        buttonControls[1].interactable = true; //button play active
    }
    public void ButtonStopAnimation() {
        if (Time.timeScale == 1) { //unpause
            targetControlAnimator.GetComponent<Animator>().SetBool("isStart", false); //return condition
            targetControlAnimator.GetComponent<Animator>().SetBool("isStop", true); //stop animation

            buttonControls[2].interactable = false; //button stop deactive
            buttonControls[0].interactable = false; //button pause deactive
            buttonControls[1].interactable = true; //button play active
        } else { //0 pause
            Time.timeScale = 1;

            ButtonStopAnimation();
        }
    }

    public void ButtonPlayAnimation() {
        if (Time.timeScale == 1) { //unpause
            targetControlAnimator.GetComponent<Animator>().SetBool("isStop", false); //return condition 
            targetControlAnimator.GetComponent<Animator>().SetBool("isStart", true); //play animation
        
            buttonControls[0].interactable = true; //button pause active
            buttonControls[2].interactable = true; //button stop active
            buttonControls[1].interactable = false; //button play deactive
        } else { //0 pause
            Time.timeScale = 1;

            buttonControls[0].interactable = true; //button pause active
            buttonControls[2].interactable = true; //button stop active
            buttonControls[1].interactable = false; //button play deactive
        }

    }

    public void TargetFound(GameObject target) {
        buttonControls[1].interactable = true; //button play active

        targetControlAnimator = target;

        if (targetControlAnimator.GetComponent<Animator>().GetBool("isStop") == true) {
            targetControlAnimator.GetComponent<Animator>().SetBool("isStop", false);
        }

        Time.timeScale = 1; // return value timescale

        // Debug.Log(Time.timeScale);
    }

    public void TargetLost() {
        for (int i = 0; i < buttonControls.Length; i++) {
            buttonControls[i].interactable = false;
        }

        if (targetControlAnimator != null) {
            if (targetControlAnimator.GetComponent<Animator>().GetBool("isStart") == true) {
                targetControlAnimator.GetComponent<Animator>().SetBool("isStart", false); //return condition
                targetControlAnimator.GetComponent<Animator>().SetBool("isStop", true); //stop animation
            }
        }

        targetControlAnimator = null;
    }
}
