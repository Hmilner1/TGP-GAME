using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheHealth : MonoBehaviour
{
   [SerializeField] float health = 100;
   [SerializeField]  float currentHealth;

    public static event Action StartDrop;

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
        //Debug.Log(currentHealth);
    }

    private void Die()
    {
        StartDrop?.Invoke();
        Destroy(this.gameObject);
    }

}
