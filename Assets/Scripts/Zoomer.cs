using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoomer : MonoBehaviour {

    public Camera camView;
    public Slider zoomSlider;

    void Awake() {

        camView.fieldOfView = 65f;
        zoomSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

    }

    public void ValueChangeCheck() {
        camView.fieldOfView = zoomSlider.value + 40;
    }

}
