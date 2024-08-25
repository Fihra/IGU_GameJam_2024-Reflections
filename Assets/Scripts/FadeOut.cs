using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeOut : MonoBehaviour
{
    [SerializeField]
    private float fadeTime;
    private TextMeshProUGUI mainText;

    // Start is called before the first frame update
    void Start()
    {
        mainText = GetComponent<TextMeshProUGUI>();
    }

    public void StartFade()
    {
        StartCoroutine(FadeTextOut());
    }

    public IEnumerator FadeTextOut()
    {
        while(mainText.color.a > 0.0f)
        {
            mainText.color = new Color(mainText.color.r, mainText.color.g, mainText.color.b, mainText.color.a - (Time.deltaTime / fadeTime));
            yield return null;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
