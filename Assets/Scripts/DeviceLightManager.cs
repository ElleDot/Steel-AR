using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class DeviceLightManager : MonoBehaviour {

    public bool lightOn;
    public Sprite lightOnSprite;
    public Sprite lightOffSprite;
    public UnityEngine.UI.Image lightButtonImage;

    public Sprite buttonOffSprite;
    public Sprite buttonOnSprite;
    public UnityEngine.UI.Image baseButtonImage;

    // Start is called before the first frame update
    void Start() {

        lightOn = false;
        CameraDevice.Instance.SetFlashTorchMode(lightOn);
        lightButtonImage.sprite = lightOffSprite;
        baseButtonImage.sprite = buttonOffSprite;

    }

    public void LightToggle() {

        lightOn ^= true;
        CameraDevice.Instance.SetFlashTorchMode(lightOn);
        lightButtonImage.sprite = lightOn == true ? lightOnSprite : lightOffSprite;
        baseButtonImage.sprite = lightOn == true ? buttonOnSprite : buttonOffSprite;

    }

}
