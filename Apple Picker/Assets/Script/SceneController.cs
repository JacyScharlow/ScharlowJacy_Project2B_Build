using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Button PlayButton, OptionsButton, QuitButton, HSButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(MainScene);
        OptionsButton.onClick.AddListener(OptionScene);
        QuitButton.onClick.AddListener(Quit);
        HSButton.onClick.AddListener(HS);
    }

    //loadscences or quit
    void MainScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    void OptionScene()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single);
    }

    void Quit()
    {
        Application.Quit();
    }

    void HS()
    {
        SceneManager.LoadScene("HighScores", LoadSceneMode.Single);
    }
}
