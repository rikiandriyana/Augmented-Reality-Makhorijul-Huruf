using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSound : MonoBehaviour
{
    public Sprite[] spriteMute;
    public Button buttonMute;
    // Start is called before the first frame update
    void Start()
    {
        if (SoundManager.Instance.music.mute == true) {
            buttonMute.image.sprite = spriteMute[1];
        } else {
            buttonMute.image.sprite = spriteMute[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonMainMenu() {
        SceneManager.LoadScene(0);
    }

    public void ButtonMute() {
        SoundManager.Instance.MuteSound();
        if (SoundManager.Instance.music.mute == true) {
            buttonMute.image.sprite = spriteMute[1];
        } else {
            buttonMute.image.sprite = spriteMute[0];
        }
    }
}
