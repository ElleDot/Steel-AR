using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRotate : MonoBehaviour {

    public float speed;
    public bool isPaused = false;
    public GameObject Rotator;
    public GameObject pauseButton;
    public Image pauseButtonImage;

    public Sprite playSprite;
    public Sprite pauseSprite;
    public Sprite clockwiseSprite;
    public Sprite antiClockwiseSprite;
    public Image flipperImage;
    public bool isReversed = false;

    private void Start() {
        speed = 10f;
        isReversed = false;
    }

    // Update is called once per frame
    void Update() {

        if (!isPaused) {

            if (isReversed) {

                Rotator.transform.Rotate(0, -speed * Time.deltaTime, 0);
                flipperImage.transform.Rotate(0, 0, -speed * Time.deltaTime * 3);

            } else {

                Rotator.transform.Rotate(0, speed * Time.deltaTime, 0);
                flipperImage.transform.Rotate(0, 0, speed * Time.deltaTime * 3);

            }

        }
        
    }

    public void PausePlay() {

        isPaused ^= true;

        if (isPaused) {
            pauseButtonImage.sprite = playSprite;
        } else {
            pauseButtonImage.sprite = pauseSprite;
        }

    }

    public void flipSpin() {

        isReversed ^= true;

        if (isReversed) {
            flipperImage.sprite = antiClockwiseSprite;
        } else {
            flipperImage.sprite = clockwiseSprite;
        }

    }

}
