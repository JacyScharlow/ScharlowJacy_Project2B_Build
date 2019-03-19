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

    // Update is called once per frame
    void MainScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainScene"));
    }

    void MMScene()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainMenu"));
    }

    void Quit()
    {
        Application.Quit();
    }
}
