using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;


public class SettingsManager : MonoBehaviour
{
    public AudioMixer m_VolumeMixer;
    private Slider m_VolumeSlider;
    private Slider m_SenseX;
    private Slider m_SenseY;

    private void Start()
    {
        m_VolumeSlider = GameObject.Find("Volume Slider").GetComponent<Slider>();
        m_SenseX = GameObject.Find("sensitivity x Slider").GetComponent<Slider>();
        m_SenseY = GameObject.Find("Sensitivity y Slider").GetComponent<Slider>();
        m_VolumeSlider.value = PlayerPrefs.GetFloat("Audio");
    }
    private void Update()
    {
        m_VolumeMixer.SetFloat("MainMixer", PlayerPrefs.GetFloat("Audio"));
    }

    public void OnAudioChanged()
    {
        PlayerPrefs.SetFloat("Audio", m_VolumeSlider.value);
    }

    public void OnSenseXChanged()
    {
        PlayerPrefs.SetFloat("SenseX", m_SenseX.value);
    }
    public void OnSenseYChanged()
    {
        PlayerPrefs.SetFloat("SenseY", m_SenseY.value);
    }



}
