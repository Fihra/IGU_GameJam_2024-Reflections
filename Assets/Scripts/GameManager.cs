using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    public List<BeatScroller> beatCharts;

    //public BeatScroller beatChart;
    public DreamScroller dreamChart;

    public float tempo;

    public bool isPlaying;
    public AudioSource music;

    public GameObject titleText;
    public GameObject startText;

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

                titleText.GetComponent<FadeOut>().StartFade();
                startText.GetComponent<FadeOut>().StartFade();

                foreach(BeatScroller chart in beatCharts)
                {
                    chart.hasStarted = true;
                }

                //beatChart.hasStarted = true;
                music.Play();
            }
        }
    }
}
