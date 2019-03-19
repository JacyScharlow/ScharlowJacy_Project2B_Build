using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Destory : MonoBehaviour
{
    public Text lifeCounter;
    int life;
    public AudioClip Fail;
    public LoadGame other;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Acorn")
        {
            Destroy(collidedWith);
            source.PlayOneShot(Fail, PlayerPrefs.GetFloat("SFXSound"));
        }
        // Score up
        life -= 1;
        lifeCounter.text = "Lives: " + life;
        if (life == 0)
        {
            other.EndGame();
            SceneManager.LoadScene("GameOver");
        }
    }
}
