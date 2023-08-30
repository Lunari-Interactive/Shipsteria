using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float myVolume;
    float tempVolume;

    public Slider audioSlider;

    public void SetVolume(float volume)
    {
        myVolume = volume;
        PlayerPrefs.SetFloat("myVolume", volume);

        audioMixer.SetFloat("MasterMixer", myVolume);

        myVolume = audioSlider.value;
    }

    private void Start()
    {
        tempVolume = PlayerPrefs.GetFloat("myVolume");
        audioMixer.SetFloat("MasterMixer", tempVolume);
        audioSlider.value = tempVolume;
    }
}
