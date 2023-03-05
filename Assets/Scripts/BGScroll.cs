using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {
    [SerializeField]
    private float scrollSpeed = 0.1f;
    private MeshRenderer meshRenderer;
    private float x_Scroll;

    void Awake() {
        meshRenderer = GetComponent<MeshRenderer>(); // Get the MeshRenderer component
    }

    /// <summary>
    ///    Scrolls the background
    /// </summary>
    void Scroll() {
        // Sets the speed and direction of the background scrolling.
        x_Scroll = Time.time * scrollSpeed;
        // Sets the offset for the main texture.
        Vector2 offset = new Vector2(x_Scroll, 0);
        // Applies the offset to the scrolling background.
        meshRenderer.material.mainTextureOffset = offset;
    }

    void Update() {
        Scroll(); // Scroll the background infinitely
    }
}
