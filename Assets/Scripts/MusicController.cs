using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour

{
    public Slider slider;
    public float sliderValue;

    public Toggle toggle;

    void Start()
    {
        Values();
        ToggleOn();
    }

    public void SceneMusic()
    {
        SceneManager.LoadScene("Music");
    }
    
    public void Values()
    {
        slider.value = PlayerPrefs.GetFloat("save", sliderValue);
    }

    public void ChangeToggle()
    {
        PlayerPrefs.SetInt("IsOn", (toggle.isOn ? 1 : 0));
    }

    public void ToggleOn()
    {
        toggle.isOn = PlayerPrefs.GetInt("IsOn", 0) == 1;
    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("save", sliderValue);
    }

}

