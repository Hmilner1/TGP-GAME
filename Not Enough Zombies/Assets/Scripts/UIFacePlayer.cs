using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIFacePlayer : MonoBehaviour
{
    public Camera m_Cam;
    public bool m_Active;
    [SerializeField]
    private Canvas m_Canvas;
    private Transform player;
    private CurrentWeapon m_weapon;
    [SerializeField] private TextMeshProUGUI mName;
    [SerializeField] private TextMeshProUGUI mFireRate;
    [SerializeField] private TextMeshProUGUI mMagSize;
    [SerializeField] private TextMeshProUGUI mDamage;
    [SerializeField] private TextMeshProUGUI mRange;
    [SerializeField] private TextMeshProUGUI mRecoil;

    private void Awake()
    {
        m_weapon = transform.parent.GetComponent<CurrentWeapon>();

        player = GameObject.FindGameObjectWithTag("player").transform;
        m_Active = false;
        m_Canvas = GetComponent<Canvas>();
        m_Cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    private void Update()
    {
        mName.text = m_weapon.mName.ToString();
        mFireRate.text = "Fire Rate: " + m_weapon.mFireTime.ToString();
        mMagSize.text = "Mag Size: " + m_weapon.mMagSize.ToString();
        mDamage.text = "Damage: " + m_weapon.mDamage.ToString();
        mRange.text = "Range: " + m_weapon.mRange.ToString();
        mRecoil.text = "Recoil: " + m_weapon.mRecoilY.ToString();
        float dist = Vector3.Distance(player.position, transform.position);
        if (dist < 7)
        {
            m_Canvas.enabled = true;
            transform.LookAt(transform.position + m_Cam.transform.rotation * Vector3.forward, m_Cam.transform.rotation * Vector3.up);
        }
        else
        {
            m_Canvas.enabled = false;
        }

    }
}
