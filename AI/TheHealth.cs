using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheHealth : MonoBehaviour, IDamageable
{
   [SerializeField] float health = 100;
   [SerializeField]  float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Die();
        }
        Debug.Log(currentHealth);
    }

    public void Die()
    {
        WaveSystem.Enemiesonthemap--;
        currentHealth = health;
        gameObject.SetActive(false); 
    }

}
