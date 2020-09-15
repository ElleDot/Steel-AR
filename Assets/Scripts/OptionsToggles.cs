using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsToggles : MonoBehaviour {

    public static int batterySaverEnabled;

    public Sprite inactiveButtonSprite;
    public Sprite activeButtonSprite;

    public Image audioButtonImage;
    public Image batteryButtonImage;

    // Start is called before the first frame update
    void Start() {

        batterySaverEnabled = PlayerPrefs.GetInt("batterySaver");

        if (SoundEffectHandler.audioEnabled == 0) {
            audioButtonImage.sprite = inactiveButtonSprite;
        }

        if (batterySaverEnabled == 0) {
            batteryButtonImage.sprite = inactiveButtonSprite;
        }

    }

    public void audioButtonToggled() {

        SoundEffectHandler.audioEnabled++;

        if (SoundEffectHandler.audioEnabled == 2) {
            SoundEffectHandler.audioEnabled = 0;
            audioButtonImage.sprite = inactiveButtonSprite;
        } else {
            audioButtonImage.sprite = activeButtonSprite;
        }

        PlayerPrefs.SetInt("audioEnabled", SoundEffectHandler.audioEnabled);

    }

    public void batterySaverToggled() {

        batterySaverEnabled++;

        if (batterySaverEnabled == 2) {
            batterySaverEnabled = 0;
            batteryButtonImage.sprite = inactiveButtonSprite;
        } else {
            batteryButtonImage.sprite = activeButtonSprite;
        }

            PlayerPrefs.SetInt("batterySaver", batterySaverEnabled);

    }

}
