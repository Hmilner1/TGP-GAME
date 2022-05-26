using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoText : MonoBehaviour
{
    private Weapon m_Weapon;

    [SerializeField]private TextMeshProUGUI m_AmmoText;
    [SerializeField] private TextMeshProUGUI m_WaveText;
    private WaveSystem m_WaveSys;
    private void Start()
    {
        m_Weapon = GameObject.Find("Weapon01").GetComponent<Weapon>();
        m_WaveSys = GameObject.Find("Wave Manager").GetComponent<WaveSystem>();
    }

    private void Update()
    {
        m_AmmoText.text = m_Weapon.mAmmo.ToString() + " / " + m_Weapon.mMagSize.ToString();
        m_WaveText.text = "Wave: " + m_WaveSys.waveNumber.ToString();
    }
}
