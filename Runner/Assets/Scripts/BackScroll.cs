using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackScroll : MonoBehaviour
{
    public float speed;
    public Renderer rndr;
    void Start()
    {
        rndr = GetComponent<Renderer>();
    }

    private void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);

        rndr.material.mainTextureOffset = offset;
    }
}
