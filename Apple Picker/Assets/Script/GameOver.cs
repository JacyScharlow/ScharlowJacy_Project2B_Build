using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Button PlayButton, MMButton, QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(MainScene);
        MMButton.onClick.AddListener(MMScene);
        QuitButton.onClick.AddListener(Quit);
    }

    // Load Scenes
    void MainScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    void MMScene()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    void Quit()
    {
        Application.Quit();
    }
}
