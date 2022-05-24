using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheHealth : MonoBehaviour
{
   [SerializeField] float health = 100;
   [SerializeField]  float currentHealth;
   public Transform m_ZombiePosition;
   public LootDrops m_DropScript;
   public int DropChance;

    public static event Action<Transform> StartDrop;

    void Start()
    {
        DropChance = UnityEngine.Random.Range(0, 10);
        currentHealth = health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        if (DropChance < 3)
        {
            m_DropScript.DropItem(m_ZombiePosition);
        }
        Destroy(this.gameObject);
    }
}
