using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float m_PlayerHealth;

    public static event Action PlayerDead;

    private void OnEnable() => BasicAI.DoDamage += TakeDamage;
    private void OnDisable() => BasicAI.DoDamage -= TakeDamage;

    private void Start()
    {
        m_PlayerHealth = 100f;
    }

    private void Update()
    {
        if (m_PlayerHealth <= 0)
        {
            PlayerDead?.Invoke();
        }
    }

    private void TakeDamage(float Amount)
    {
        m_PlayerHealth = m_PlayerHealth - Amount;
        Debug.Log(m_PlayerHealth);
    }

}
