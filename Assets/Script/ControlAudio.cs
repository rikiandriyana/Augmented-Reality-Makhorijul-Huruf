using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlAudio : MonoBehaviour
{
    public AudioSource audioDefault;
    public AudioClip[] audioClips;
    public Image[] imageButtonAudio;
    public Sprite[] spriteButtonAudio; //0 active 1 stop
    int indexButtonAudio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeSpriteButtonAudio() {
        imageButtonAudio[indexButtonAudio].sprite = spriteButtonAudio[0]; //change sprite button
    }

    public void ButtonAudioActivate(int numberImage) {
        if (audioDefault.isPlaying == false) {
            audioDefault.clip = audioClips[numberImage]; //get clips
            audioDefault.Play();
            imageButtonAudio[numberImage].sprite = spriteButtonAudio[1]; ///change sprite button

            indexButtonAudio = numberImage;
            Invoke("ChangeSpriteButtonAudio", audioClips[numberImage].length);
        } else {
            
            audioDefault.Stop();
            imageButtonAudio[indexButtonAudio].sprite = spriteButtonAudio[0]; //change sprite button
            CancelInvoke("ChangeSpriteButtonAudio"); //cancel jika di stop

            if (numberImage != indexButtonAudio) {
                ButtonAudioActivate(numberImage);
            }
        }
        
    }
}
