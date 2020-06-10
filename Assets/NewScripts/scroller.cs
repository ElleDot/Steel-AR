using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroller : MonoBehaviour {

    public GameObject backQuad;
    public GameObject sheenQuad;
    private Renderer backQuadRenderer;
    private Renderer sheenQuadRenderer;

    float scrollSpeed = 0.03f;

    void Start() {
        backQuadRenderer = backQuad.GetComponent<Renderer>();
        sheenQuadRenderer = sheenQuad.GetComponent<Renderer>();
    }

    void Update() {
        Vector2 backTextureOffset = new Vector2(0, -(Time.time * scrollSpeed));
        Vector2 sheenTextureOffset = new Vector2(0, (Time.time * scrollSpeed*10));
        backQuadRenderer.material.mainTextureOffset = backTextureOffset;
        sheenQuadRenderer.material.mainTextureOffset = sheenTextureOffset;
    }
}
