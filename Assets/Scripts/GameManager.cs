using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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

    bool isChartDone = false;

    public GameObject titleText;
    public GameObject startText;

    public GameObject thankYouText;
    public GameObject restartText;
    public GameObject successText;
    public GameObject missText;

    /// <summary>
    /// Score Tracker
    /// </summary>
    private int score = 0;
    private int miss = 0;

    public void AddScore()
    {
        score += 1;
    }

    public void AddMiss()
    {
        miss += 1;
    }

    public List<int> FinalScore()
    {
        List<int> mainScore = new List<int>();
        mainScore.Add(score);
        mainScore.Add(miss);

        return mainScore;
    }

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
        if(!isPlaying && !isChartDone)
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
        else
        {
            if(music.time > 148f)
            {
                isChartDone = true;
            }
            //Debug.Log(music.time);
        }

        if(isChartDone)
        {
            thankYouText.SetActive(true);
            restartText.SetActive(true);

            //successText.GetComponent<TMP_Text>().text = "Success: " + FinalScore()[0];
            //missText.GetComponent<TMP_Text>().text = "Miss: " + FinalScore()[1];

            //successText.SetActive(true);
            //missText.SetActive(true);

            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
