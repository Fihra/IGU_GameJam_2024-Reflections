using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float scrollSpeed;

    public Vector2 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, 20);
        transform.position = startPosition + Vector2.right * newPosition;
    }
}
