using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlButtonAudio : MonoBehaviour
{
    public Button buttonPlay, buttonPause, buttonStop;
    public AudioSource audioDefault;
    public AudioClip[] audioClipObjects;
    GameObject objectTarget;
    public GameObject[] objectARs;
    bool isPaused;
    float sisaWaktu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayingAudioDone() {
        buttonPlay.interactable = true;
        buttonPause.interactable = false;
        buttonStop.interactable = false;
    }

    void SetUpAudioClip() { //untuk mengambil audioclip sesuai dengan object
        for (int i = 0; i < objectARs.Length; i++) {
            if (objectARs[i].name == objectTarget.name) {
                audioDefault.clip = audioClipObjects[i]; //input clip audiosource

                break;
            }
        }
    }

    public void ButtonPause() {
        buttonPlay.interactable = true;

        buttonPause.interactable = false;

        sisaWaktu = audioDefault.time;
        Debug.Log(audioDefault.time);

        audioDefault.Pause();
        isPaused = true;

        CancelInvoke();
    }

    public void ButtonStop() {
        buttonPlay.interactable = true;

        buttonPause.interactable = false;
        buttonStop.interactable = false;

        isPaused = false;

        audioDefault.Stop();

        CancelInvoke();
    }

    public void ButtonPlay() {
        buttonStop.interactable = true;

        buttonPlay.interactable = false;
        buttonPause.interactable = true;

        if (isPaused == true) {
            audioDefault.UnPause(); //lanjutkan dari pause

            isPaused = false;

            // Invoke("PlayingAudioDone", audioDefault.clip.length - sisaWaktu); //melanjutkan audio dengan sisa waktu invoke
        } else {
            audioDefault.Play(); //mainkan dari awal

            // Invoke("PlayingAudioDone", audioDefault.clip.length); //invoke dari awal
            audioDefault.loop = true;
        }
    } 

    public void TargetFound(GameObject target) {
        buttonPlay.interactable = true;

        objectTarget = target;

        SetUpAudioClip();
    }

    public void TargetLost() {
        buttonPlay.interactable = false;
        buttonPause.interactable = false;
        buttonStop.interactable = false;

        if (objectTarget != null) {
            audioDefault.Stop();

            CancelInvoke();

            isPaused = false;
        }

        objectTarget = null;
    }
}
