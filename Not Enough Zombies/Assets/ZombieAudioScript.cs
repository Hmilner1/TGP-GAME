using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAudioScript : MonoBehaviour
{
    public AudioSource m_ZombieNoiseSource;
    public AudioClip m_ZombieClip1;
    public AudioClip m_ZombieClip2;
    public AudioClip m_ZombieClip3;
    private float noiseTime;
    public int soundClip;

    private void Start()
    {
        noiseTime = Random.Range(5, 20);
        soundClip = Random.Range(0, 2);
        StartCoroutine(MakeNoise());
    }

    IEnumerator MakeNoise()
    {
        yield return new WaitForSeconds(noiseTime);
        switch (soundClip)
        {
            case 0:
                m_ZombieNoiseSource.clip = m_ZombieClip1;
                m_ZombieNoiseSource.Play();
                break;
            case 1:
                m_ZombieNoiseSource.clip = m_ZombieClip2;
                m_ZombieNoiseSource.Play();
                break;
            case 2:
                m_ZombieNoiseSource.clip = m_ZombieClip3;
                m_ZombieNoiseSource.Play();
                break;
        }
    }
}
