using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{

    public Slider musicSlider;
    public Slider SFXSlider;

    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicSound");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXSound");
        musicSlider.onValueChanged.AddListener(MusicChange);
        SFXSlider.onValueChanged.AddListener(SFXchange);
    }



    //update saved playerprefs for options
    private void Update()
    {
        
    }

    public void MusicChange(float value)
    {
        PlayerPrefs.SetFloat("MusicSound", value);
        Debug.Log(value);
    }

    public void SFXchange(float value)
    {
        PlayerPrefs.SetFloat("SFXSound", value);
        Debug.Log(value);
    }
}
