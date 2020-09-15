using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundEffectHandler : MonoBehaviour {

    public static int audioEnabled;

    public AudioSource source;
    public AudioClip intro;
    public AudioClip pressBegin;
    public AudioClip pressEnd;
    public AudioClip back;
    public AudioClip ting;
    public AudioClip ok;
    public AudioClip whoosh;
    public AudioClip ascend;
    public AudioClip descend;

    // Start is called before the first frame update
    void Start() {

        audioEnabled = PlayerPrefs.GetInt("audioEnabled");

        if (audioEnabled == 1) {

            switch (SceneManager.GetActiveScene().name) {

                case "MainMenu":
                    source.clip = intro;
                    break;
                case "ModelViewer":
                    source.clip = whoosh;
                    break;
                case "SettingsScreen":
                    source.clip = ascend;
                    break;
                case "HelpScreen":
                    source.clip = ascend;
                    break;

            }
   
            source.Play();

        }

    }

    public void PressBegin() {

        if (audioEnabled == 1) {
            source.clip = pressBegin;
            source.Play();
        }

    }

    public void PressEnd() {

        if (audioEnabled == 1) {
            source.clip = pressEnd;
            source.Play();
        }

    }

    public void GoBack() {

        if (audioEnabled == 1) {
            source.clip = back;
            source.Play();
        }

    }

    public void Info() {

        if (audioEnabled == 1) {
            source.clip = ting;
            source.Play();
        }

    }

    public void OK() {

        if (audioEnabled == 1) {
            source.clip = ok;
            source.Play();
        }

    }

    public void Ascend() {

        if (audioEnabled == 1) {
            source.clip = ascend;
            source.Play();
        }

    }

    public void Descend() {

        if (audioEnabled == 1) {
            source.clip = descend;
            source.Play();
        }

    }

}
