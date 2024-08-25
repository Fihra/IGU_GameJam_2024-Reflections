using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    bool canBePressed = false;

    public bool startNote;

    const float FADEOUTTIME = 0.5f;

    SpriteRenderer sr;

    PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<PlayerController>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if((pc.isPressed && canBePressed))
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
            GameManager.instance.AddScore();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Activator"))
        {
            canBePressed = true;
        }

        if(other.CompareTag("Dream"))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Activator"))
        {
            canBePressed = false;
            GameManager.instance.AddMiss();
            Destroy(gameObject);
        }
    }
}
