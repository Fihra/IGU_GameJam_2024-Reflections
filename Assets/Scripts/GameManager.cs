using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public BeatScroller beatChart;
    public DreamScroller dreamChart;

    public float tempo;

    public bool isPlaying;
    public AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!isPlaying)
        {
            if(Input.anyKeyDown)
            {
                isPlaying = true;
                dreamChart.hasStarted = true;
                beatChart.hasStarted = true;
                music.Play();
            }
        }
    }
}
