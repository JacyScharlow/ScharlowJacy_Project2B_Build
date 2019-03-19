using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Back : MonoBehaviour
{
    public Button back;

    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void MainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
