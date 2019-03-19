using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squirrel : MonoBehaviour
{
    //public GameObject basket;
    public float speed = .2f;
    public Text ScoreCounter;
    static int score;
    public AudioClip Success;
    public LoadGame other;
    static float SFXsliderValue;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 7 )
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -7 )
        {
            transform.Translate(-speed, 0, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Acorn")
        {
            Destroy(collidedWith);
            source.PlayOneShot(Success, PlayerPrefs.GetFloat("SFXSound"));
        }
        // Score up
        score += 1;
        ScoreCounter.text = "Score: " + score;
        if (PlayerPrefs.GetInt("Current Score") == 0)
        {
            PlayerPrefs.SetInt("Current Score", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Current Score", PlayerPrefs.GetInt("Current Score")+1);
        }
    }
}
