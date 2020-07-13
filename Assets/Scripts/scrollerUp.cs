using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollerUp : MonoBehaviour
{

    public GameObject sheenQuad;
    private Renderer sheenQuadRenderer;

    float scrollSpeed = 0.03f;

    void Start()
    {
        sheenQuadRenderer = sheenQuad.GetComponent<Renderer>();
    }

    void Update()
    {
        Vector2 sheenTextureOffset = new Vector2(0, (Time.time * scrollSpeed * 5));
        sheenQuadRenderer.material.mainTextureOffset = sheenTextureOffset;
    }
}
