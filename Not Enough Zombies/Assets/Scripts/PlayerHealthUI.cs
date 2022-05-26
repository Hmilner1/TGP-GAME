using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PlayerHealthUI : MonoBehaviour
{

    public static PlayerHealthUI Instance;
    
    private float _health;
    private float _backHealth;
    private float _lerpTimer = 1f;

    //public float maxHealth = 100;
    public float maxHealth;
    public float chipSpeed = 2f;
    
    public Slider frontHealthSlider;
    public Slider backHealthSlider;
    
    
    private void Awake()
    {
        Instance = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        SetMaxHealth(maxHealth);
        _health = maxHealth;
        _backHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        _health = Mathf.Clamp(_health, 0, maxHealth);
        _backHealth = Mathf.Clamp(_backHealth, 0, maxHealth);
        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        Debug.Log(_health);
        UpdateBackSliderHealth(_health);
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        SetHealth(_health);
        _lerpTimer = 0f;
    }

    public void SetMaxHealth(float health)
    {
        frontHealthSlider.maxValue = health;
        frontHealthSlider.value = health;
        backHealthSlider.maxValue = health;
        backHealthSlider.value = health;
    }

    public void SetHealth(float health)
    {
        frontHealthSlider.value = health;
    }

    public void UpdateBackSliderHealth(float health)
    {
        if (health < 0)
            return;
        health = backHealthSlider.value;
        if (_backHealth > _health)
        {
            _lerpTimer += Time.deltaTime;
            float percentComplete = _lerpTimer / chipSpeed;
            backHealthSlider.value = Mathf.Lerp(health, _health, percentComplete);
        }
    }
}
