using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ObjectTracker : MonoBehaviour
{
    public GameObject objectActive; // ini kosongan

    //play some sound
    public AudioSource audioDefault;
    public AudioClip[] audioClipsObject;
    public GameObject[] ObjectChilds;
    int indexSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TargetFound(GameObject objectAR) {
        objectActive = objectAR;

        Animator anim = objectActive.GetComponent<Animator>();
        anim.SetBool("isPlay", true);

        //play sound
        for (int i = 0; i < ObjectChilds.Length; i++) {
            if(ObjectChilds[i].name == objectActive.name) {
                indexSound = i;

                break;
            }
        }

        audioDefault.clip = audioClipsObject[indexSound];
        audioDefault.Play();
    }

    public void TargetNotFound() {
        //stop sound
        audioDefault.Stop();
        
        if (objectActive != null) {
            Animator anim = objectActive.GetComponent<Animator>();
            anim.SetBool("isPlay", false);
        }
        objectActive = null;
    }
}
