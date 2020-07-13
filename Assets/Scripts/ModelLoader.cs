﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ModelLoader : MonoBehaviour {

    public string modelName;
    GameObject modelObject;

    public TextMeshProUGUI modelNameLabel;
    public TextMeshProUGUI modelAuthorLabel;

    public GameObject infoPanel;
    public GameObject infoBox;
    public TextMeshProUGUI infoModelName;
    public TextMeshProUGUI infoAuthorName;
    public TextMeshProUGUI infoDescription;
    CanvasGroup alphaMod;

    private void Start() {

        if (SceneManager.GetActiveScene().name == "ModelViewer") {

            modelName = PlayerPrefs.GetString("modelName", "No Name");
            ModelLoad(modelName);
            alphaMod = infoPanel.GetComponent<CanvasGroup>();

        }

    }

    public void ModelPrep() {

        print("Setting " + modelName + " for loading.");
        PlayerPrefs.SetString("modelName", modelName);

    }

    public void ModelLoad(string modelToLoad) {

        print("MODEL LOAD FOR: " + modelToLoad + " ATTEMPTED");
        modelObject = GameObject.Find(modelToLoad);

        modelObject.transform.Translate(Vector3.up * -25, Space.World);

        if (modelName == "alpaca") {

            modelNameLabel.text = "Alpaca";
            modelAuthorLabel.text = " by Example Name 1";
            infoModelName.text = "Alpaca";
            infoAuthorName.text = "<AuthorName>";
            infoDescription.text = "This is an Alpaca model, provided by <name> who worked on the SteelAR project.";

        } else if (modelName == "tonight") {

            modelNameLabel.text = "'Tonight'";
            modelAuthorLabel.text = "By Example Name 2";
            infoModelName.text = "Tonight";
            infoAuthorName.text = "<AuthorName>";
            infoDescription.text = "This is an animated lyric from Richard Hawley's \"Tonight the Streets are Ours\".";

        } else if (modelName == "forklift") {

            modelNameLabel.text = "Forklift";
            modelAuthorLabel.text = "by Unknown";
            infoModelName.text = "Forklift";
            infoAuthorName.text = "Unknown";
            infoDescription.text = "This is a forklift model taken from the internet. I've no idea who made it, and this paragraph is just filler text.";

        } else if (modelName == "robot") {

            modelNameLabel.text = "Astro-Bot";
            modelAuthorLabel.text = "By Unknown";
            infoModelName.text = "Astro-Bot";
            infoAuthorName.text = "Unknown";
            infoDescription.text = "This is a forklift model taken from the internet. I've no idea who made it, and this paragraph is just filler text.";
        }

    }

    public void ShowInfo() {

        infoPanel.SetActive(true);
        StartCoroutine(FadeImage(true));

    }

    public void HideInfo() {

        StartCoroutine(FadeImage(false));

    }


    Vector3 cachedBoxOriginalPosition = new Vector3((Screen.width/2), (Screen.height/2), 0);
    IEnumerator FadeImage(bool fadeAway){

        float amount = (float)Screen.height/20;
        Vector3 downPos = new Vector3(0, amount, 0);

        // fade out
        if (!fadeAway) {
            // decreasing i
            for (float i = 1; i >= 0; i -= Time.deltaTime) {

                infoBox.transform.position = Vector3.MoveTowards(infoBox.transform.position, cachedBoxOriginalPosition-downPos, 50 * 2f * Time.unscaledDeltaTime);
                alphaMod.alpha = i;
                yield return null;
            }

            infoPanel.SetActive(false);

        } else {

            infoBox.transform.position = cachedBoxOriginalPosition - downPos;

            // fade in
            for (float i = 0; i <= 1; i += Time.deltaTime) {

                infoBox.transform.position = Vector3.MoveTowards(infoBox.transform.position, cachedBoxOriginalPosition, 50 * 2f * Time.unscaledDeltaTime);
                alphaMod.alpha = i;
                yield return null;
            }
        }
    }

}
