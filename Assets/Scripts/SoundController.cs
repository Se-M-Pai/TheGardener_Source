using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    public AudioMixerGroup Mixer;
    [SerializeField] GameObject musicSlider;
    [SerializeField] GameObject soundSlider;

    private void Start()
    {
        musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolume");
        soundSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("SoundVolume");
    }

    public void ChangeVolumeMusic(float value)
    {
        Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, value));
        PlayerPrefs.SetFloat("MusicVolume", value);
    }

    public void ChangeVolumeSound(float volume)
    {
        Mixer.audioMixer.SetFloat("SoundVolume", Mathf.Lerp(-80, 0, volume));
        PlayerPrefs.SetFloat("SoundVolume", volume);
    }
}
