using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    bool canBePressed = false;

    public bool startNote;

    PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if((pc.isPressed && canBePressed))
        {
            gameObject.SetActive(false);
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
        }
    }
}
