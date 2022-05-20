using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
		if (currentHealth > maxHealth)
        {
			currentHealth = maxHealth;
        }
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log("Damaged");
			TakeDamage(20);
		}

		if (Input.GetButtonDown("Fire1"))
        {
			if (currentHealth < maxHealth)
            {
				Debug.Log("Healed");
				TakeHeal(Random.Range(5,10));
            }
        }
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

	void TakeHeal(int heal)
    {
		currentHealth += heal;

		healthBar.SetHealth(currentHealth);
    }
}
