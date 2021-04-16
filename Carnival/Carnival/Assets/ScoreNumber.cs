using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreNumber : MonoBehaviour
{
    public static int scorevalue = 0;
    public static int count = 0;
    public Text Score;
    private int timelimit;
    //public bool timeleft;
    // Start is called before the first frame update
    void Start()
    {
        timelimit = 60;
        Score = GetComponent<Text>();
        //timeleft = true;
    }

    // Update is called once per frame
    void Update()
    {

        Score.text = "Score: " + scorevalue;
        if (scorevalue > 200) {
            Score.text = "Score: "+ scorevalue+ ". This works";
        }
    }
}
