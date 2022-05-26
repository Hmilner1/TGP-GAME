using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PlayerHealthTest : MonoBehaviour, TestControls.IPlayerMovementActions
{
    private TestControls _input;
    
    public static PlayerHealthTest Instance;
    
    private float _health;
    private float _backHealth;
    private float _lerpTimer = 1f;

    public float maxHealth = 100;
    public float chipSpeed = 2f;
    
    public Slider frontHealthSlider;
    public Slider backHealthSlider;
    
    
    private void Awake()
    {
        Instance = this;
        _input = new TestControls();
        _input.PlayerMovement.SetCallbacks(this);
        
        _input.PlayerMovement.Enable();
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
        //SetHealth(_health);
        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        Debug.Log(_health);
        UpdateBackSliderHealth(_health);
        /*float fillF = frontHealthSlider.value;
        float fillB = backHealthSlider.value;
        float hFraction = _health / maxHealth; //healthFraction;
        if (fillB > hFraction)
        {
            //frontHealthSlider.value = hFraction;
            _lerpTimer += Time.deltaTime;
            float percentComplete = _lerpTimer / chipSpeed;
            backHealthSlider.value = Mathf.Lerp(fillB, hFraction, percentComplete);
        }*/
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        SetHealth(_health);
        //UpdateHealthUI();
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
        //backHealthSlider.value = health;
    }

    public void UpdateBackSliderHealth(float health)
    {
        //if (health <= 0) throw new ArgumentOutOfRangeException(nameof(health));
        if (health < 0)
            return;
        health = backHealthSlider.value;
        if (_backHealth > _health)
        {
            //frontHealthSlider.value = hFraction;
            _lerpTimer += Time.deltaTime;
            float percentComplete = _lerpTimer / chipSpeed;
            backHealthSlider.value = Mathf.Lerp(health, _health, percentComplete);
        }
    }

    #region Input System Controls

    

    
    public void OnTakeDamage(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            Debug.Log("A Key Pressed");
            //TakeDamage(Random.Range(5,10));
            TakeDamage(Random.Range(5,10));
            //TakeDamage(10);
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        // non
    }
    
    
    public void OnHealDamage(InputAction.CallbackContext context)
    {
        // non
    }
    
    #endregion
}
