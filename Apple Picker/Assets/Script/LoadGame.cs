using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    private readonly int defaultHighScore = 0;
    private int score;
    private int temp;
    

    public void StartGame()
    {
        if (!PlayerPrefs.HasKey("High Score 1"))
        { // Check to see if a high score is already saved
            PlayerPrefs.SetInt("High Score 1", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 2", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 3", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 4", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 5", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 6", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 7", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 8", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 9", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("High Score 10", defaultHighScore); // If it’s not, then save one
            PlayerPrefs.SetInt("Current Score", defaultHighScore);
            PlayerPrefs.SetFloat("MusicSound", 1);
            PlayerPrefs.SetFloat("SFXSound", 1);

        }
    }

    public void EndGame()
    {
        score = PlayerPrefs.GetInt("Current Score", defaultHighScore);
        if (score > PlayerPrefs.GetInt("High Score 1"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 1");
            PlayerPrefs.SetInt("High Score 1", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 2"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 2");
            PlayerPrefs.SetInt("High Score 2", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 3"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 3");
            PlayerPrefs.SetInt("High Score 3", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 4"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 4");
            PlayerPrefs.SetInt("High Score 4", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 5"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 5");
            PlayerPrefs.SetInt("High Score 5", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 6"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 6");
            PlayerPrefs.SetInt("High Score 6", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 7"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 7");
            PlayerPrefs.SetInt("High Score 7", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 8"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 8");
            PlayerPrefs.SetInt("High Score 8", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 9"))
        { // Check to see if the current score beats the high score
            temp = PlayerPrefs.GetInt("High Score 9");
            PlayerPrefs.SetInt("High Score 9", score); // If it does, save it instead
            score = temp;
        }

        if (score > PlayerPrefs.GetInt("High Score 10"))
        { // Check to see if the current score beats the high score
            PlayerPrefs.SetInt("High Score 10", score); // If it does, save it instead
        }
        PlayerPrefs.SetInt("Current Score", defaultHighScore);
    }
}
