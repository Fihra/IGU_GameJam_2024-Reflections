using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer sprite;

    Color onPress = new Color32(255, 255, 255, 130);
    Color regular = new Color32(255, 255, 255, 255);

    public bool isPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            isPressed = true;
            sprite.color = onPress;
        }
        else
        {
            sprite.color = regular;
            isPressed = false;
        }
    }
}
