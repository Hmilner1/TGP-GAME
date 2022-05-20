//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{

    public int maxHealth = 150;
    public int currentHealth;

    public HealthBar healthBar;
    public GameObject FloatingTextPrefab;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage (int amount)
    {
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth); 

        //trigger floating text here
        if (FloatingTextPrefab)
        {
            ShowFloatingText();
        }

        Debug.Log(gameObject.name + " health = " + currentHealth);
        if (currentHealth <= 0f)
        {
            Die();
        }
    }

    void ShowFloatingText()
    {
        var go = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMeshPro>().text = currentHealth.ToString();
        go.GetComponent<TextMeshPro>().faceColor = healthBar.fill.color;
    }


    void Die ()
    {
        ScoringSystem.points += 50;
        Destroy(gameObject);
    }
    
}
