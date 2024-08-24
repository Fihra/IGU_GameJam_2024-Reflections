using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ScrollDirection
{
    TopScroll,
    BottomScroll,
    LeftScroll,
    RightScroll
        
}

public class BeatScroller : MonoBehaviour
{
    public float tempo;
    public bool hasStarted;

    public ScrollDirection direction;

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
            switch(direction)
            {
                case ScrollDirection.LeftScroll:
                    transform.position -= new Vector3(tempo * Time.deltaTime, transform.position.y, transform.position.z);
                    break;
                case ScrollDirection.RightScroll:
                    transform.position += new Vector3(tempo * Time.deltaTime, 0, 0);
                    break;
                default:
                    return;
            }

            //if(direction == ScrollDirection.LeftScroll)
            //{
            //    transform.position -= new Vector3(tempo * Time.deltaTime, transform.position.y, transform.position.z);
            //}
            
        }
    }
}
