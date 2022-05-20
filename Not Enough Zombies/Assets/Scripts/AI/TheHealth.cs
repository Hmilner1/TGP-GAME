using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheHealth : MonoBehaviour
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
        PointAllocationDmg();
        if(currentHealth <= 0)
        {
            Die();
        }
        //Debug.Log(currentHealth);
    }

    private void Die()
    {
        PointAllocation();
        Destroy(this.gameObject);
    }
    
    private void PointAllocation()
    {
        PointsManager.Instance.SetPoint(PointsManager.TypesOfMobs.Zombie);
    }
    
    private void PointAllocationDmg()
    {
        PointsManager.Instance.SetPoint(PointsManager.TypesOfMobs.GeneralZombie);
    }

}
