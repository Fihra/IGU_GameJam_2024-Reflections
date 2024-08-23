using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamScroller : MonoBehaviour
{
    public float tempo;
    public bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        tempo = tempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {

        }
        else
        {
            transform.position += new Vector3(tempo * Time.deltaTime, 0, 0);
        }
    }
}
