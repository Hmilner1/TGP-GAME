using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoText : MonoBehaviour
{
    private Weapon m_Weapon;

    [SerializeField]private TextMeshProUGUI m_AmmoText;

    private void Start()
    {
        m_Weapon = GameObject.Find("Weapon01").GetComponent<Weapon>();
    }

    private void Update()
    {
        m_AmmoText.text = m_Weapon.mAmmo.ToString() + " / " + m_Weapon.mMagSize.ToString();
        
    }
}
