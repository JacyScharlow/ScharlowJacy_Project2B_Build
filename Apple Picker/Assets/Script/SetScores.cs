using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SetScores : MonoBehaviour
{
    public Text score1, score2, score3, score4, score5, score6, score7, score8, score9, score10;
    // Start is called before the first frame update
    void Start()
    {
        score1.text = "" + PlayerPrefs.GetInt("High Score 1");
        score2.text = "" + PlayerPrefs.GetInt("High Score 2");
        score3.text = "" + PlayerPrefs.GetInt("High Score 3");
        score4.text = "" + PlayerPrefs.GetInt("High Score 4");
        score5.text = "" + PlayerPrefs.GetInt("High Score 5");
        score6.text = "" + PlayerPrefs.GetInt("High Score 6");
        score7.text = "" + PlayerPrefs.GetInt("High Score 7");
        score8.text = "" + PlayerPrefs.GetInt("High Score 8");
        score9.text = "" + PlayerPrefs.GetInt("High Score 9");
        score10.text = "" + PlayerPrefs.GetInt("High Score 10");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
