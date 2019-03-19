using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tree : MonoBehaviour
{
    // Prefab for instantiating apples
    public GameObject tree;
    public GameObject acornPrefab;

    // Speed at which the AppleTree moves in meters/second
    public float speed = 3f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 7f;

    // Chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.01f;

    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 2f;

    public bool gameStarted = false;

    public Text Tutorial;

    public AudioClip Spawn;
    static float SFXsliderValue;

    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        // Dropping apples every second
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
        source = GetComponent<AudioSource>();
    }
    void DropApple()
    {
        if (gameStarted)
        {
            source.PlayOneShot(Spawn, PlayerPrefs.GetFloat("SFXSound"));
            Instantiate(acornPrefab, tree.transform.position, Quaternion.identity);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) gameStarted = true;
        if (gameStarted)
        {
            Tutorial.text = "";
            // Basic Movement
            Vector3 pos = tree.transform.position;
            pos.x += speed * Time.deltaTime;
            tree.transform.position = pos;
            // Changing Direction
            if (pos.x < -leftAndRightEdge || pos.x > leftAndRightEdge)
            {
                speed *= -1;
            }
        }
    }
    void FixedUpdate()
    {
        // Changing Direction Randomly
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;  // Change direction
        }
    }
}
